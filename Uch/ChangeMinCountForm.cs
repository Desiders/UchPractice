namespace Uch;

public partial class ChangeMinCountForm : Form
{
    private int _oldMaxMinCount;

    public int NewMinCount;

    public ChangeMinCountForm(int oldMaxMinCount)
    {
        _oldMaxMinCount = oldMaxMinCount;

        InitializeComponent();
    }

    private void ChangeMinCountForm_Load(object sender, EventArgs e)
    {
        txtInput.Text = _oldMaxMinCount.ToString();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtInput.Text, out int value) && value >= 0)
        {
            NewMinCount = value;
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show("Введите корректное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
