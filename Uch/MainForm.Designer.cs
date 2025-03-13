namespace Uch
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxSearch = new TextBox();
            comboBoxSort = new ComboBox();
            comboBoxFilter = new ComboBox();
            panelMaterials = new Panel();
            lblCurrentPage = new Label();
            btnLeft1 = new Button();
            btnLeft2 = new Button();
            btnRight1 = new Button();
            btnRight2 = new Button();
            lblCountText = new Label();
            lblCount = new Label();
            btnChangeMinCount = new Button();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Введите для поиска";
            textBoxSearch.Size = new Size(197, 23);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "По названию (А-Я)", "По названию (Я-А)", "По количеству (по возр.)", "По количеству (по убыв.)", "По цене (по возр.)", "По цене (по убыв.)" });
            comboBoxSort.Location = new Point(260, 11);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(198, 23);
            comboBoxSort.TabIndex = 1;
            comboBoxSort.Text = "Сортировка";
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Все типы" });
            comboBoxFilter.Location = new Point(260, 40);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(198, 23);
            comboBoxFilter.TabIndex = 2;
            comboBoxFilter.Text = "Фильтрация";
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // panelMaterials
            // 
            panelMaterials.AutoScroll = true;
            panelMaterials.Location = new Point(12, 78);
            panelMaterials.Name = "panelMaterials";
            panelMaterials.Size = new Size(447, 302);
            panelMaterials.TabIndex = 3;
            // 
            // lblCurrentPage
            // 
            lblCurrentPage.AutoSize = true;
            lblCurrentPage.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPage.Location = new Point(327, 408);
            lblCurrentPage.Name = "lblCurrentPage";
            lblCurrentPage.Size = new Size(56, 18);
            lblCurrentPage.TabIndex = 4;
            lblCurrentPage.Text = "34 / 34";
            // 
            // btnLeft1
            // 
            btnLeft1.BackColor = Color.Transparent;
            btnLeft1.FlatAppearance.BorderSize = 0;
            btnLeft1.FlatStyle = FlatStyle.Flat;
            btnLeft1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeft1.Location = new Point(293, 406);
            btnLeft1.Name = "btnLeft1";
            btnLeft1.Size = new Size(28, 23);
            btnLeft1.TabIndex = 5;
            btnLeft1.Text = "<";
            btnLeft1.UseVisualStyleBackColor = false;
            btnLeft1.Click += btnLeft1_Click;
            // 
            // btnLeft2
            // 
            btnLeft2.BackColor = Color.Transparent;
            btnLeft2.FlatAppearance.BorderSize = 0;
            btnLeft2.FlatStyle = FlatStyle.Flat;
            btnLeft2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeft2.Location = new Point(244, 406);
            btnLeft2.Name = "btnLeft2";
            btnLeft2.Size = new Size(43, 23);
            btnLeft2.TabIndex = 6;
            btnLeft2.Text = "<<";
            btnLeft2.UseVisualStyleBackColor = false;
            btnLeft2.Click += btnLeft2_Click;
            // 
            // btnRight1
            // 
            btnRight1.BackColor = Color.Transparent;
            btnRight1.FlatAppearance.BorderSize = 0;
            btnRight1.FlatStyle = FlatStyle.Flat;
            btnRight1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRight1.Location = new Point(389, 406);
            btnRight1.Name = "btnRight1";
            btnRight1.Size = new Size(28, 23);
            btnRight1.TabIndex = 7;
            btnRight1.Text = ">";
            btnRight1.UseVisualStyleBackColor = false;
            btnRight1.Click += btnRight1_Click;
            // 
            // btnRight2
            // 
            btnRight2.BackColor = Color.Transparent;
            btnRight2.FlatAppearance.BorderSize = 0;
            btnRight2.FlatStyle = FlatStyle.Flat;
            btnRight2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRight2.Location = new Point(423, 406);
            btnRight2.Name = "btnRight2";
            btnRight2.Size = new Size(35, 23);
            btnRight2.TabIndex = 8;
            btnRight2.Text = ">>";
            btnRight2.UseVisualStyleBackColor = false;
            btnRight2.Click += btnRight2_Click;
            // 
            // lblCountText
            // 
            lblCountText.AutoSize = true;
            lblCountText.Location = new Point(12, 48);
            lblCountText.Name = "lblCountText";
            lblCountText.Size = new Size(123, 15);
            lblCountText.TabIndex = 9;
            lblCountText.Text = "Количество страниц:";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(141, 48);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 15);
            lblCount.TabIndex = 10;
            // 
            // btnChangeMinCount
            // 
            btnChangeMinCount.Location = new Point(12, 399);
            btnChangeMinCount.Name = "btnChangeMinCount";
            btnChangeMinCount.Size = new Size(226, 30);
            btnChangeMinCount.TabIndex = 11;
            btnChangeMinCount.Text = "Изменить минимальное количество";
            btnChangeMinCount.UseVisualStyleBackColor = true;
            btnChangeMinCount.Visible = false;
            btnChangeMinCount.Click += btnChangeMinCount_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 441);
            Controls.Add(btnChangeMinCount);
            Controls.Add(lblCount);
            Controls.Add(lblCountText);
            Controls.Add(btnRight2);
            Controls.Add(btnRight1);
            Controls.Add(btnLeft2);
            Controls.Add(btnLeft1);
            Controls.Add(lblCurrentPage);
            Controls.Add(panelMaterials);
            Controls.Add(comboBoxFilter);
            Controls.Add(comboBoxSort);
            Controls.Add(textBoxSearch);
            Name = "MainForm";
            Text = "Главное меню";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearch;
        private ComboBox comboBoxSort;
        private ComboBox comboBoxFilter;
        private Panel panelMaterials;
        private Label lblCurrentPage;
        private Button btnLeft1;
        private Button btnLeft2;
        private Button btnRight1;
        private Button btnRight2;
        private Label lblCountText;
        private Label lblCount;
        private Button btnChangeMinCount;
    }
}
