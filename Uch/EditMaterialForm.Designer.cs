namespace Uch
{
    partial class EditMaterialForm
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
            lblName = new Label();
            lblType = new Label();
            lblImagePath = new Label();
            lblPrice = new Label();
            lblCount = new Label();
            lblMinCount = new Label();
            lblCountPerOne = new Label();
            lblUnitType = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            tbxName = new TextBox();
            tbxImagePath = new TextBox();
            tbxPrice = new TextBox();
            tbxCount = new TextBox();
            tbxMinCount = new TextBox();
            tbxCountPerOne = new TextBox();
            tbxUnitType = new TextBox();
            cbxTypes = new ComboBox();
            lbxMaterialProviders = new ListBox();
            lblMaterialProviders = new Label();
            lblMaterialProvidersHelp = new Label();
            lblAllProviders = new Label();
            lblAllProvidersHelp = new Label();
            lbxAllProviders = new ListBox();
            btnDelete = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Название:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 34);
            lblType.Name = "lblType";
            lblType.Size = new Size(30, 15);
            lblType.TabIndex = 1;
            lblType.Text = "Тип:";
            // 
            // lblImagePath
            // 
            lblImagePath.AutoSize = true;
            lblImagePath.Location = new Point(12, 59);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(83, 15);
            lblImagePath.TabIndex = 2;
            lblImagePath.Text = "Путь к файлу:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 84);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Цена:";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(12, 109);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(75, 15);
            lblCount.TabIndex = 4;
            lblCount.Text = "Количество:";
            // 
            // lblMinCount
            // 
            lblMinCount.AutoSize = true;
            lblMinCount.Location = new Point(12, 134);
            lblMinCount.Name = "lblMinCount";
            lblMinCount.Size = new Size(157, 15);
            lblMinCount.TabIndex = 5;
            lblMinCount.Text = "Минимальное количество:";
            // 
            // lblCountPerOne
            // 
            lblCountPerOne.AutoSize = true;
            lblCountPerOne.Location = new Point(12, 159);
            lblCountPerOne.Name = "lblCountPerOne";
            lblCountPerOne.Size = new Size(137, 15);
            lblCountPerOne.TabIndex = 6;
            lblCountPerOne.Text = "Количество в упаковке:";
            // 
            // lblUnitType
            // 
            lblUnitType.AutoSize = true;
            lblUnitType.Location = new Point(12, 184);
            lblUnitType.Name = "lblUnitType";
            lblUnitType.Size = new Size(119, 15);
            lblUnitType.TabIndex = 7;
            lblUnitType.Text = "Единица измерения:";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(112, 226);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 226);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnOk_Click;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(175, 9);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(160, 23);
            tbxName.TabIndex = 10;
            // 
            // tbxImagePath
            // 
            tbxImagePath.Location = new Point(175, 59);
            tbxImagePath.Name = "tbxImagePath";
            tbxImagePath.Size = new Size(160, 23);
            tbxImagePath.TabIndex = 12;
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(175, 84);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(160, 23);
            tbxPrice.TabIndex = 13;
            // 
            // tbxCount
            // 
            tbxCount.Location = new Point(175, 109);
            tbxCount.Name = "tbxCount";
            tbxCount.Size = new Size(160, 23);
            tbxCount.TabIndex = 14;
            // 
            // tbxMinCount
            // 
            tbxMinCount.Location = new Point(175, 134);
            tbxMinCount.Name = "tbxMinCount";
            tbxMinCount.Size = new Size(160, 23);
            tbxMinCount.TabIndex = 15;
            // 
            // tbxCountPerOne
            // 
            tbxCountPerOne.Location = new Point(175, 159);
            tbxCountPerOne.Name = "tbxCountPerOne";
            tbxCountPerOne.Size = new Size(160, 23);
            tbxCountPerOne.TabIndex = 16;
            // 
            // tbxUnitType
            // 
            tbxUnitType.Location = new Point(175, 184);
            tbxUnitType.Name = "tbxUnitType";
            tbxUnitType.Size = new Size(160, 23);
            tbxUnitType.TabIndex = 17;
            // 
            // cbxTypes
            // 
            cbxTypes.FormattingEnabled = true;
            cbxTypes.Location = new Point(175, 34);
            cbxTypes.Name = "cbxTypes";
            cbxTypes.Size = new Size(160, 23);
            cbxTypes.TabIndex = 18;
            // 
            // lbxMaterialProviders
            // 
            lbxMaterialProviders.DisplayMember = "Name";
            lbxMaterialProviders.FormattingEnabled = true;
            lbxMaterialProviders.Location = new Point(499, 9);
            lbxMaterialProviders.Name = "lbxMaterialProviders";
            lbxMaterialProviders.SelectionMode = SelectionMode.MultiSimple;
            lbxMaterialProviders.Size = new Size(157, 94);
            lbxMaterialProviders.TabIndex = 19;
            // 
            // lblMaterialProviders
            // 
            lblMaterialProviders.AutoSize = true;
            lblMaterialProviders.Location = new Point(350, 9);
            lblMaterialProviders.Name = "lblMaterialProviders";
            lblMaterialProviders.Size = new Size(129, 15);
            lblMaterialProviders.TabIndex = 20;
            lblMaterialProviders.Text = "Текущие поставщики:";
            // 
            // lblMaterialProvidersHelp
            // 
            lblMaterialProvidersHelp.AutoSize = true;
            lblMaterialProvidersHelp.Location = new Point(350, 24);
            lblMaterialProvidersHelp.Name = "lblMaterialProvidersHelp";
            lblMaterialProvidersHelp.Size = new Size(132, 15);
            lblMaterialProvidersHelp.TabIndex = 21;
            lblMaterialProvidersHelp.Text = "(выберите удаляемые)";
            // 
            // lblAllProviders
            // 
            lblAllProviders.AutoSize = true;
            lblAllProviders.Location = new Point(350, 134);
            lblAllProviders.Name = "lblAllProviders";
            lblAllProviders.Size = new Size(100, 15);
            lblAllProviders.TabIndex = 22;
            lblAllProviders.Text = "Все поставщики:";
            // 
            // lblAllProvidersHelp
            // 
            lblAllProvidersHelp.AutoSize = true;
            lblAllProvidersHelp.Location = new Point(350, 149);
            lblAllProvidersHelp.Name = "lblAllProvidersHelp";
            lblAllProvidersHelp.Size = new Size(146, 15);
            lblAllProvidersHelp.TabIndex = 23;
            lblAllProvidersHelp.Text = "(выберите добавляемые)";
            // 
            // lbxAllProviders
            // 
            lbxAllProviders.DisplayMember = "Name";
            lbxAllProviders.FormattingEnabled = true;
            lbxAllProviders.Location = new Point(499, 109);
            lbxAllProviders.Name = "lbxAllProviders";
            lbxAllProviders.SelectionMode = SelectionMode.MultiSimple;
            lbxAllProviders.Size = new Size(157, 94);
            lbxAllProviders.TabIndex = 24;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(212, 226);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // EditMaterialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 261);
            Controls.Add(btnDelete);
            Controls.Add(lbxAllProviders);
            Controls.Add(lblAllProvidersHelp);
            Controls.Add(lblAllProviders);
            Controls.Add(lblMaterialProvidersHelp);
            Controls.Add(lblMaterialProviders);
            Controls.Add(lbxMaterialProviders);
            Controls.Add(cbxTypes);
            Controls.Add(tbxUnitType);
            Controls.Add(tbxCountPerOne);
            Controls.Add(tbxMinCount);
            Controls.Add(tbxCount);
            Controls.Add(tbxPrice);
            Controls.Add(tbxImagePath);
            Controls.Add(tbxName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblUnitType);
            Controls.Add(lblCountPerOne);
            Controls.Add(lblMinCount);
            Controls.Add(lblCount);
            Controls.Add(lblPrice);
            Controls.Add(lblImagePath);
            Controls.Add(lblType);
            Controls.Add(lblName);
            Name = "EditMaterialForm";
            Text = "Редактирование материала";
            Load += EditMaterialForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblType;
        private Label lblImagePath;
        private Label lblPrice;
        private Label lblCount;
        private Label lblMinCount;
        private Label lblCountPerOne;
        private Label lblUnitType;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbxName;
        private TextBox tbxImagePath;
        private TextBox tbxPrice;
        private TextBox tbxCount;
        private TextBox tbxMinCount;
        private TextBox tbxCountPerOne;
        private TextBox tbxUnitType;
        private ComboBox cbxTypes;
        private ListBox lbxMaterialProviders;
        private Label lblMaterialProviders;
        private Label lblMaterialProvidersHelp;
        private Label lblAllProviders;
        private Label lblAllProvidersHelp;
        private ListBox lbxAllProviders;
        private Button btnDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}