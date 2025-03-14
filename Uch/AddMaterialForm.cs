using System.Data;
using static Uch.Database;
using static Uch.Models;

namespace Uch
{
    public partial class AddMaterialForm : Form
    {
        private readonly AppDbContext _db;
        private readonly Material _newMaterial;

        public AddMaterialForm(AppDbContext db)
        {
            _db = db;
            _newMaterial = new Material();

            InitializeComponent();
        }

        private void AddMaterialForm_Load(object sender, EventArgs e)
        {
            LoadTypes();
            LoadProviders();
        }

        private void LoadTypes()
        {
            var types = _db.Materials
               .Select(m => m.Type)
               .Distinct()
               .OrderBy(t => t);

            cbxTypes.Items.AddRange(types.ToArray());
        }

        private void LoadProviders()
        {
            lbxMaterialProviders.Items.Clear();
            var allProviders = _db.Providers.OrderBy(p => p.Name);

            lbxMaterialProviders.Items.AddRange(allProviders.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> errors = new();

            if (string.IsNullOrWhiteSpace(tbxName.Text))
                errors.Add("Название материала");
            if (string.IsNullOrWhiteSpace(tbxUnitType.Text))
                errors.Add("Единица измерения");
            if (cbxTypes.SelectedItem == null)
                errors.Add("Тип материала");
            if (!int.TryParse(tbxCount.Text, out int count) || count < 0)
                errors.Add("Количество (должно быть неотрицательным числом)");
            if (!int.TryParse(tbxMinCount.Text, out int minCount) || minCount < 0)
                errors.Add("Минимальное количество (должно быть неотрицательным числом)");
            if (!int.TryParse(tbxCountPerOne.Text, out int countPerOne) || countPerOne < 0)
                errors.Add("Количество на единицу (должно быть неотрицательным числом)");
            if (!double.TryParse(tbxPrice.Text, out double price) || price < 0)
                errors.Add("Цена (должна быть положительным числом)");

            if (errors.Count > 0)
            {
                MessageBox.Show($"Исправьте следующие ошибки:\n- {string.Join("\n- ", errors)}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _newMaterial.Name = tbxName.Text;
            _newMaterial.Type = (string)cbxTypes.SelectedItem!;
            _newMaterial.Count = count;
            _newMaterial.MinCount = minCount;
            _newMaterial.CountPerOne = countPerOne;
            _newMaterial.Price = price;
            _newMaterial.UnitType = tbxUnitType.Text;
            _newMaterial.MaterialProviders = new List<MaterialProvider>();

            foreach (Provider provider in lbxMaterialProviders.SelectedItems)
            {
                _newMaterial.MaterialProviders.Add(new()
                {
                    Provider = provider
                });
            }

            _db.Materials.Add(_newMaterial);
            _db.SaveChanges();

            MessageBox.Show("Материал успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
