using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using static Uch.Database;
using static Uch.Models;

namespace Uch;

public partial class MainForm : Form
{
    private readonly AppDbContext db;

    private const int pageSize = 3;
    private int currentPage = 1;
    private int currentMaterials;
    private int totalMaterials;
    private int totalPages;

    private List<Material> selectedMaterials = new();

    public MainForm(IServiceProvider provider)
    {
        db = provider.GetRequiredService<AppDbContext>();

        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        CalculateTotalMaterials();
        CalculatePages();
        LoadFilterTypes();
        LoadMaterials(currentPage);
        UpdatePaginationButtons();
    }

    private void CalculateTotalMaterials()
    {
        currentMaterials = totalMaterials = db.Materials.Count();
    }

    private void CalculatePages()
    {
        totalPages = (int)Math.Ceiling((double)currentMaterials / pageSize);
        if (totalPages == 0) totalPages = 1;
    }

    private void LoadFilterTypes()
    {
        var types = db.Materials
           .Select(m => m.Type)
           .Distinct()
           .OrderBy(t => t).ToArray();

        foreach (var type in types)
        {
            comboBoxFilter.Items.Add(type);
        }

        comboBoxFilter.SelectedIndex = 0;
    }

    private void LoadMaterials(int page)
    {
        var query = db.Materials
            .Include(m => m.MaterialProviders)
            .ThenInclude(mp => mp.Provider).AsQueryable();

        if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
        {
            query = query.Where(m => EF.Functions.Like(m.Name, $"%{textBoxSearch.Text}%"));
        }

        query = ApplySorting(query);
        if (comboBoxFilter.SelectedItem != null && comboBoxFilter.SelectedIndex != 0)
        {
            query = ApplyFilter(query);
        }

        var materials = query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
        currentMaterials = query.Count();

        CalculatePages();
        UpdatePaginationButtons();

        panelMaterials.Controls.Clear();

        lblCount.Text = $"{currentMaterials} / {totalMaterials}";

        foreach (var material in materials)
        {
            var card = new MaterialCard(material)
            {
                Dock = DockStyle.Top
            };
            card.SelectionChanged += OnMaterialSelected;
            card.EditRequested += OnMaterialEditRequested;
            panelMaterials.Controls.Add(card);
            panelMaterials.Controls.SetChildIndex(card, 0);
        }
    }

    private IQueryable<Material> ApplyFilter(IQueryable<Material> query)
    {
        return query.Where(m => m.Type == comboBoxFilter.SelectedItem);
    }

    private IQueryable<Material> ApplySorting(IQueryable<Material> query)
    {
        return comboBoxSort.SelectedIndex switch
        {
            0 => query.OrderBy(m => m.Name),
            1 => query.OrderByDescending(m => m.Name),
            2 => query.OrderBy(m => m.Count),
            3 => query.OrderByDescending(m => m.Count),
            4 => query.OrderBy(m => m.Price),
            5 => query.OrderByDescending(m => m.Price),
            _ => query
        };
    }

    private void OnMaterialSelected(Material material, bool isSelected)
    {
        if (isSelected)
        {
            selectedMaterials.Add(material);
        }
        else
        {
            selectedMaterials.Remove(material);
        }
        btnChangeMinCount.Visible = selectedMaterials.Count > 0;
    }

    private void OnMaterialEditRequested(Material material)
    {
        var form = new EditMaterialForm(db, material);
        if (form.ShowDialog() == DialogResult.OK)
        {
            CalculateTotalMaterials(); // if material has been deleted
            LoadMaterials(currentPage);
        }
    }

    private void UpdatePaginationButtons()
    {
        btnLeft1.Enabled = currentPage > 1;
        btnLeft2.Enabled = currentPage > 1;
        btnRight1.Enabled = currentPage < totalPages;
        btnRight2.Enabled = currentPage < totalPages;
        lblCurrentPage.Text = $"{currentPage} / {totalPages}";
    }

    private void btnLeft2_Click(object sender, EventArgs e)
    {
        currentPage = 1;
        UpdatePagination();
    }

    private void btnLeft1_Click(object sender, EventArgs e)
    {
        if (currentPage > 1)
        {
            currentPage--;
            UpdatePagination();
        }
    }

    private void btnRight1_Click(object sender, EventArgs e)
    {
        if (currentPage < totalPages)
        {
            currentPage++;
            UpdatePagination();
        }
    }

    private void btnRight2_Click(object sender, EventArgs e)
    {
        currentPage = totalPages;
        UpdatePagination();
    }

    private void UpdatePagination()
    {
        LoadMaterials(currentPage);
        UpdatePaginationButtons();
    }

    private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentPage = 1;
        LoadMaterials(currentPage);
    }

    private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentPage = 1;
        LoadMaterials(currentPage);
    }

    private void textBoxSearch_TextChanged(object sender, EventArgs e)
    {
        currentPage = 1;
        LoadMaterials(currentPage);
    }

    private void btnChangeMinCount_Click(object sender, EventArgs e)
    {
        if (selectedMaterials.Count == 0) return;

        int oldMaxMinCount = selectedMaterials.Max(m => m.MinCount);

        var form = new ChangeMinCountForm(oldMaxMinCount);
        if (form.ShowDialog() == DialogResult.OK)
        {
            db.Materials
                .Where(m => selectedMaterials.Select(sm => sm.Id).Contains(m.Id))
                .ExecuteUpdate(setters => setters.SetProperty(m => m.MinCount, form.NewMinCount));
            db.SaveChanges();
            db.ChangeTracker.Clear();
            selectedMaterials.Clear();

            LoadMaterials(currentPage);
        }
    }
}

public class MaterialCard : UserControl
{
    private CheckBox checkBox;
    public event Action<Material, bool> SelectionChanged;
    public event Action<Material> EditRequested;

    public MaterialCard(Material material)
    {
        Width = 440;
        Height = 100;
        BorderStyle = BorderStyle.FixedSingle;

        int threshold = material.MinCount * 3;

        if (material.Count < material.MinCount)
        {
            BackColor = ColorTranslator.FromHtml("#d19292");
        }
        else if (material.Count <= threshold)
        {
            BackColor = ColorTranslator.FromHtml("#ffba01");
        }

        var resourcesPath = Path.Combine(Application.StartupPath, "resources");

        var pictureBox = new PictureBox
        {
            Width = 80,
            Height = 80,
            SizeMode = PictureBoxSizeMode.StretchImage,
            Image = string.IsNullOrEmpty(material.ImagePath)
                ? Image.FromStream(new MemoryStream(Resource1.default_material))
                : Image.FromFile(Path.Combine(resourcesPath, material.ImagePath))
        };

        var lblTitle = new Label
        {
            Text = $"{material.Type} | {material.Name}",
            Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
            AutoSize = true
        };

        var lblMinCount = new Label
        {
            Text = $"Минимальное количество: {material.MinCount} шт",
            AutoSize = true
        };

        var lblStock = new Label
        {
            Text = $"Остаток: {material.Count} шт",
            AutoSize = true,
            TextAlign = ContentAlignment.MiddleRight
        };

        var btnEdit = new Button
        {
            Text = "✎",
            AutoSize = true,
            Width = 25,
            Height = 25,
            BackColor = Color.LightGray,
            FlatStyle = FlatStyle.Flat,
        };
        btnEdit.Click += (s, e) => EditRequested?.Invoke(material);

        var infoPanel = new FlowLayoutPanel
        {
            FlowDirection = FlowDirection.TopDown,
            AutoSize = true
        };
        infoPanel.Controls.Add(lblTitle);
        infoPanel.Controls.Add(lblMinCount);

        var providersText = string.Join(", ", material.MaterialProviders.Select(mp => mp.Provider.Name));
        if (!string.IsNullOrEmpty(providersText))
        {
            var lblProviders = new Label
            {
                Text = "Поставщики: " + providersText,
                Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold),
                AutoSize = true,
                TextAlign = ContentAlignment.TopLeft,
                MaximumSize = new Size(300, 0),
            };
            infoPanel.Controls.Add(lblProviders);
        }

        checkBox = new CheckBox
        {
            AutoSize = true,
            Margin = new Padding(5, 5, 5, 5),
        };
        checkBox.CheckedChanged += (s, e) => SelectionChanged?.Invoke(material, checkBox.Checked);

        var table = new TableLayoutPanel
        {
            ColumnCount = 5,
            RowCount = 1,
            Dock = DockStyle.Fill
        };

        table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30));
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30));

        table.Controls.Add(checkBox, 0, 0);
        table.Controls.Add(pictureBox, 1, 0);
        table.Controls.Add(infoPanel, 2, 0);
        table.Controls.Add(lblStock, 3, 0);
        table.Controls.Add(btnEdit, 4, 0);

        Controls.Add(table);
    }
}