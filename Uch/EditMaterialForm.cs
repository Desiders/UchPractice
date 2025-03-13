using System.Data;
using Microsoft.EntityFrameworkCore;
using static Uch.Database;
using static Uch.Models;

namespace Uch
{
    public partial class EditMaterialForm : Form
    {
        private readonly AppDbContext _db;
        private readonly Material _material;

        public EditMaterialForm(AppDbContext db, Material material)
        {
            _db = db;
            _material = material;

            InitializeComponent();
        }

        private void EditMaterialForm_Load(object sender, EventArgs e)
        {
            LoadTypes();
            LoadDefault();
            LoadProviders();
        }

        private void LoadDefault()
        {
            tbxName.Text = _material.Name;
            cbxTypes.SelectedItem = _material.Type;
            tbxCount.Text = _material.Count.ToString();
            tbxMinCount.Text = _material.MinCount.ToString();
            tbxCountPerOne.Text = _material.CountPerOne.ToString();
            tbxPrice.Text = _material.Price.ToString();
        }

        private void LoadTypes()
        {
            var types = _db.Materials
               .Select(m => m.Type)
               .Distinct()
               .OrderBy(t => t).ToArray();

            foreach (var type in types)
            {
                cbxTypes.Items.Add(type);
            }
        }

        private void LoadProviders()
        {
            lbxMaterialProviders.Items.Clear();
            lbxAllProviders.Items.Clear();

            var materialProviders = _db.MaterialsProviders
                .Where(mp => mp.MaterialsId == _material.Id)
                .Select(mp => mp.Provider)
                .OrderBy(p => p.Name)
                .ThenBy(p => p.StartDate);
            var allProviders = _db.Providers
                .Except(materialProviders)
                .OrderBy(p => p.Name)
                .ThenBy(p => p.StartDate);

            lbxMaterialProviders.Items.AddRange(materialProviders.ToArray());
            lbxAllProviders.Items.AddRange(allProviders.ToArray());
        }

        private void UpdateMaterialProviders()
        {
            var selectedToRemove = lbxMaterialProviders.SelectedItems.Cast<Provider>().ToList();
            foreach (var provider in selectedToRemove)
            {
                _db.MaterialsProviders
                    .Where(mp => mp.MaterialsId == _material.Id && selectedToRemove.Select(p => p.Id).Contains(mp.ProvidersId))
                    .ExecuteDelete();
            }

            var selectedToAdd = lbxAllProviders.SelectedItems.Cast<Provider>().ToList();
            foreach (var provider in selectedToAdd)
            {
                _db.MaterialsProviders.Add(new()
                {
                    MaterialsId = _material.Id,
                    ProvidersId = provider.Id
                });
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<string> errors = new();

            if (string.IsNullOrWhiteSpace(tbxName.Text))
                errors.Add("Название материала");
            if (cbxTypes.SelectedItem == null)
                errors.Add("Тип материала");
            if (string.IsNullOrWhiteSpace(tbxCount.Text))
                errors.Add("Количество");
            if (string.IsNullOrWhiteSpace(tbxMinCount.Text))
                errors.Add("Минимальное количество");
            if (string.IsNullOrWhiteSpace(tbxCountPerOne.Text))
                errors.Add("Количество на единицу");
            if (string.IsNullOrWhiteSpace(tbxPrice.Text))
                errors.Add("Цена");

            if (errors.Count > 0)
            {
                MessageBox.Show($"Заполните следующие поля:\n- {string.Join("\n- ", errors)}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbxCount.Text, out int count))
                errors.Add("Количество (должно быть числом)");
            if (!int.TryParse(tbxMinCount.Text, out int minCount))
                errors.Add("Минимальное количество (должно быть числом)");
            if (!int.TryParse(tbxCountPerOne.Text, out int countPerOne))
                errors.Add("Количество на единицу (должно быть числом)");
            if (!double.TryParse(tbxPrice.Text, out double price))
                errors.Add("Цена (должна быть числом)");

            if (errors.Count > 0)
            {
                MessageBox.Show($"Исправьте следующие ошибки:\n- {string.Join("\n- ", errors)}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (count < 0 || minCount < 0 || countPerOne < 0 || price < 0)
            {
                MessageBox.Show("Числовые значения не могут быть отрицательными!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _material.Name = tbxName.Text;
            _material.Type = (string)cbxTypes.SelectedItem!;
            _material.Count = count;
            _material.MinCount = minCount;
            _material.CountPerOne = countPerOne;
            _material.Price = price;

            UpdateMaterialProviders();

            _db.SaveChanges();
            _db.ChangeTracker.Clear();

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Вы уверены, что хотите удалить этот материал?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _db.Materials.Remove(_material);
                _db.SaveChanges();

                MessageBox.Show("Материал успешно удалён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении материала: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
