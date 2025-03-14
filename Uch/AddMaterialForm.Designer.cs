namespace Uch
{
    partial class AddMaterialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbxMaterialProviders = new ListBox();
            lblAllProvidersHelp = new Label();
            lblAllProviders = new Label();
            cbxTypes = new ComboBox();
            tbxUnitType = new TextBox();
            tbxCountPerOne = new TextBox();
            tbxMinCount = new TextBox();
            tbxCount = new TextBox();
            tbxPrice = new TextBox();
            tbxImagePath = new TextBox();
            tbxName = new TextBox();
            btnCancel = new Button();
            btnAdd = new Button();
            lblUnitType = new Label();
            lblCountPerOne = new Label();
            lblMinCount = new Label();
            lblCount = new Label();
            lblPrice = new Label();
            lblImagePath = new Label();
            lblType = new Label();
            lblName = new Label();
            SuspendLayout();
            // 
            // lbxMaterialProviders
            // 
            lbxMaterialProviders.DisplayMember = "Name";
            lbxMaterialProviders.FormattingEnabled = true;
            lbxMaterialProviders.Location = new Point(515, 10);
            lbxMaterialProviders.Name = "lbxMaterialProviders";
            lbxMaterialProviders.SelectionMode = SelectionMode.MultiSimple;
            lbxMaterialProviders.Size = new Size(157, 94);
            lbxMaterialProviders.TabIndex = 49;
            // 
            // lblAllProvidersHelp
            // 
            lblAllProvidersHelp.AutoSize = true;
            lblAllProvidersHelp.Location = new Point(366, 50);
            lblAllProvidersHelp.Name = "lblAllProvidersHelp";
            lblAllProvidersHelp.Size = new Size(146, 15);
            lblAllProvidersHelp.TabIndex = 48;
            lblAllProvidersHelp.Text = "(выберите добавляемые)";
            // 
            // lblAllProviders
            // 
            lblAllProviders.AutoSize = true;
            lblAllProviders.Location = new Point(366, 35);
            lblAllProviders.Name = "lblAllProviders";
            lblAllProviders.Size = new Size(100, 15);
            lblAllProviders.TabIndex = 47;
            lblAllProviders.Text = "Все поставщики:";
            // 
            // cbxTypes
            // 
            cbxTypes.FormattingEnabled = true;
            cbxTypes.Location = new Point(175, 35);
            cbxTypes.Name = "cbxTypes";
            cbxTypes.Size = new Size(160, 23);
            cbxTypes.TabIndex = 43;
            // 
            // tbxUnitType
            // 
            tbxUnitType.Location = new Point(175, 185);
            tbxUnitType.Name = "tbxUnitType";
            tbxUnitType.Size = new Size(160, 23);
            tbxUnitType.TabIndex = 42;
            // 
            // tbxCountPerOne
            // 
            tbxCountPerOne.Location = new Point(175, 160);
            tbxCountPerOne.Name = "tbxCountPerOne";
            tbxCountPerOne.Size = new Size(160, 23);
            tbxCountPerOne.TabIndex = 41;
            // 
            // tbxMinCount
            // 
            tbxMinCount.Location = new Point(175, 135);
            tbxMinCount.Name = "tbxMinCount";
            tbxMinCount.Size = new Size(160, 23);
            tbxMinCount.TabIndex = 40;
            // 
            // tbxCount
            // 
            tbxCount.Location = new Point(175, 110);
            tbxCount.Name = "tbxCount";
            tbxCount.Size = new Size(160, 23);
            tbxCount.TabIndex = 39;
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(175, 85);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(160, 23);
            tbxPrice.TabIndex = 38;
            // 
            // tbxImagePath
            // 
            tbxImagePath.Location = new Point(175, 60);
            tbxImagePath.Name = "tbxImagePath";
            tbxImagePath.Size = new Size(160, 23);
            tbxImagePath.TabIndex = 37;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(175, 10);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(160, 23);
            tbxName.TabIndex = 36;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(112, 227);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblUnitType
            // 
            lblUnitType.AutoSize = true;
            lblUnitType.Location = new Point(12, 185);
            lblUnitType.Name = "lblUnitType";
            lblUnitType.Size = new Size(119, 15);
            lblUnitType.TabIndex = 33;
            lblUnitType.Text = "Единица измерения:";
            // 
            // lblCountPerOne
            // 
            lblCountPerOne.AutoSize = true;
            lblCountPerOne.Location = new Point(12, 160);
            lblCountPerOne.Name = "lblCountPerOne";
            lblCountPerOne.Size = new Size(137, 15);
            lblCountPerOne.TabIndex = 32;
            lblCountPerOne.Text = "Количество в упаковке:";
            // 
            // lblMinCount
            // 
            lblMinCount.AutoSize = true;
            lblMinCount.Location = new Point(12, 135);
            lblMinCount.Name = "lblMinCount";
            lblMinCount.Size = new Size(157, 15);
            lblMinCount.TabIndex = 31;
            lblMinCount.Text = "Минимальное количество:";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(12, 110);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(75, 15);
            lblCount.TabIndex = 30;
            lblCount.Text = "Количество:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 85);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 15);
            lblPrice.TabIndex = 29;
            lblPrice.Text = "Цена:";
            // 
            // lblImagePath
            // 
            lblImagePath.AutoSize = true;
            lblImagePath.Location = new Point(12, 60);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(83, 15);
            lblImagePath.TabIndex = 28;
            lblImagePath.Text = "Путь к файлу:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 35);
            lblType.Name = "lblType";
            lblType.Size = new Size(30, 15);
            lblType.TabIndex = 27;
            lblType.Text = "Тип:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 15);
            lblName.TabIndex = 26;
            lblName.Text = "Название:";
            // 
            // AddMaterialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 261);
            Controls.Add(lbxMaterialProviders);
            Controls.Add(lblAllProvidersHelp);
            Controls.Add(lblAllProviders);
            Controls.Add(cbxTypes);
            Controls.Add(tbxUnitType);
            Controls.Add(tbxCountPerOne);
            Controls.Add(tbxMinCount);
            Controls.Add(tbxCount);
            Controls.Add(tbxPrice);
            Controls.Add(tbxImagePath);
            Controls.Add(tbxName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(lblUnitType);
            Controls.Add(lblCountPerOne);
            Controls.Add(lblMinCount);
            Controls.Add(lblCount);
            Controls.Add(lblPrice);
            Controls.Add(lblImagePath);
            Controls.Add(lblType);
            Controls.Add(lblName);
            Name = "AddMaterialForm";
            Text = "Добавление материала";
            Load += AddMaterialForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private ListBox lbxMaterialProviders;
        private Label lblAllProvidersHelp;
        private Label lblAllProviders;
        private ComboBox cbxTypes;
        private TextBox tbxUnitType;
        private TextBox tbxCountPerOne;
        private TextBox tbxMinCount;
        private TextBox tbxCount;
        private TextBox tbxPrice;
        private TextBox tbxImagePath;
        private TextBox tbxName;
        private Button btnCancel;
        private Button btnAdd;
        private Label lblUnitType;
        private Label lblCountPerOne;
        private Label lblMinCount;
        private Label lblCount;
        private Label lblPrice;
        private Label lblImagePath;
        private Label lblType;
        private Label lblName;
    }
}