namespace wsr7.Forms.EntitiesForms
{
    partial class RieltorsForm
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
            this.Fie_Search = new System.Windows.Forms.TextBox();
            this.But_Dell = new wsr7.CustomForms.CustomButton();
            this.GroupEdit = new System.Windows.Forms.GroupBox();
            this.customLabel5 = new wsr7.CustomForms.CustomLabel();
            this.fie_edit_familia = new System.Windows.Forms.TextBox();
            this.customLabel6 = new wsr7.CustomForms.CustomLabel();
            this.fie_edit_name = new System.Windows.Forms.TextBox();
            this.customLabel7 = new wsr7.CustomForms.CustomLabel();
            this.fie_edit_comissia = new System.Windows.Forms.TextBox();
            this.customLabel8 = new wsr7.CustomForms.CustomLabel();
            this.fie_edit_otchestvo = new System.Windows.Forms.TextBox();
            this.But_Edit = new wsr7.CustomForms.CustomButton();
            this.GroupAdd = new System.Windows.Forms.GroupBox();
            this.customLabel4 = new wsr7.CustomForms.CustomLabel();
            this.customLabel3 = new wsr7.CustomForms.CustomLabel();
            this.fie_add_comissia = new System.Windows.Forms.TextBox();
            this.customLabel2 = new wsr7.CustomForms.CustomLabel();
            this.fie_add_otchestvo = new System.Windows.Forms.TextBox();
            this.fie_add_name = new System.Windows.Forms.TextBox();
            this.customLabel1 = new wsr7.CustomForms.CustomLabel();
            this.fie_add_familia = new System.Windows.Forms.TextBox();
            this.But_Add = new wsr7.CustomForms.CustomButton();
            this.Grid_Rieltors = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_prev = new wsr7.CustomForms.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.go_Supplies = new wsr7.CustomForms.CustomButton();
            this.go_Demands = new wsr7.CustomForms.CustomButton();
            this.GroupEdit.SuspendLayout();
            this.GroupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Rieltors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Fie_Search
            // 
            this.Fie_Search.Location = new System.Drawing.Point(12, 661);
            this.Fie_Search.Name = "Fie_Search";
            this.Fie_Search.Size = new System.Drawing.Size(842, 20);
            this.Fie_Search.TabIndex = 9;
            this.Fie_Search.TextChanged += new System.EventHandler(this.Fie_Search_TextChanged);
            // 
            // But_Dell
            // 
            this.But_Dell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.But_Dell.Location = new System.Drawing.Point(584, 223);
            this.But_Dell.Name = "But_Dell";
            this.But_Dell.Size = new System.Drawing.Size(268, 27);
            this.But_Dell.TabIndex = 8;
            this.But_Dell.Text = "Удалить";
            this.But_Dell.UseVisualStyleBackColor = false;
            this.But_Dell.Click += new System.EventHandler(this.But_Dell_Click);
            // 
            // GroupEdit
            // 
            this.GroupEdit.Controls.Add(this.customLabel5);
            this.GroupEdit.Controls.Add(this.fie_edit_familia);
            this.GroupEdit.Controls.Add(this.customLabel6);
            this.GroupEdit.Controls.Add(this.fie_edit_name);
            this.GroupEdit.Controls.Add(this.customLabel7);
            this.GroupEdit.Controls.Add(this.fie_edit_comissia);
            this.GroupEdit.Controls.Add(this.customLabel8);
            this.GroupEdit.Controls.Add(this.fie_edit_otchestvo);
            this.GroupEdit.Controls.Add(this.But_Edit);
            this.GroupEdit.Location = new System.Drawing.Point(298, 12);
            this.GroupEdit.Name = "GroupEdit";
            this.GroupEdit.Size = new System.Drawing.Size(280, 248);
            this.GroupEdit.TabIndex = 7;
            this.GroupEdit.TabStop = false;
            this.GroupEdit.Text = "Редактировать";
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel5.Location = new System.Drawing.Point(6, 162);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(102, 20);
            this.customLabel5.TabIndex = 26;
            this.customLabel5.Text = "* Комиссия";
            // 
            // fie_edit_familia
            // 
            this.fie_edit_familia.Location = new System.Drawing.Point(6, 39);
            this.fie_edit_familia.Name = "fie_edit_familia";
            this.fie_edit_familia.Size = new System.Drawing.Size(268, 20);
            this.fie_edit_familia.TabIndex = 22;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel6.Location = new System.Drawing.Point(6, 111);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(103, 20);
            this.customLabel6.TabIndex = 27;
            this.customLabel6.Text = "* Отчество";
            // 
            // fie_edit_name
            // 
            this.fie_edit_name.Location = new System.Drawing.Point(6, 85);
            this.fie_edit_name.Name = "fie_edit_name";
            this.fie_edit_name.Size = new System.Drawing.Size(268, 20);
            this.fie_edit_name.TabIndex = 23;
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel7.Location = new System.Drawing.Point(6, 62);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(55, 20);
            this.customLabel7.TabIndex = 25;
            this.customLabel7.Text = "* Имя";
            // 
            // fie_edit_comissia
            // 
            this.fie_edit_comissia.Location = new System.Drawing.Point(6, 185);
            this.fie_edit_comissia.Name = "fie_edit_comissia";
            this.fie_edit_comissia.Size = new System.Drawing.Size(268, 20);
            this.fie_edit_comissia.TabIndex = 24;
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel8.Location = new System.Drawing.Point(6, 16);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(100, 20);
            this.customLabel8.TabIndex = 24;
            this.customLabel8.Text = "* Фамилия";
            // 
            // fie_edit_otchestvo
            // 
            this.fie_edit_otchestvo.Location = new System.Drawing.Point(6, 134);
            this.fie_edit_otchestvo.Name = "fie_edit_otchestvo";
            this.fie_edit_otchestvo.Size = new System.Drawing.Size(268, 20);
            this.fie_edit_otchestvo.TabIndex = 25;
            // 
            // But_Edit
            // 
            this.But_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.But_Edit.Location = new System.Drawing.Point(6, 211);
            this.But_Edit.Name = "But_Edit";
            this.But_Edit.Size = new System.Drawing.Size(268, 27);
            this.But_Edit.TabIndex = 5;
            this.But_Edit.Text = "Изменить";
            this.But_Edit.UseVisualStyleBackColor = false;
            this.But_Edit.Click += new System.EventHandler(this.But_Edit_Click);
            // 
            // GroupAdd
            // 
            this.GroupAdd.Controls.Add(this.customLabel4);
            this.GroupAdd.Controls.Add(this.customLabel3);
            this.GroupAdd.Controls.Add(this.fie_add_comissia);
            this.GroupAdd.Controls.Add(this.customLabel2);
            this.GroupAdd.Controls.Add(this.fie_add_otchestvo);
            this.GroupAdd.Controls.Add(this.fie_add_name);
            this.GroupAdd.Controls.Add(this.customLabel1);
            this.GroupAdd.Controls.Add(this.fie_add_familia);
            this.GroupAdd.Controls.Add(this.But_Add);
            this.GroupAdd.Location = new System.Drawing.Point(12, 12);
            this.GroupAdd.Name = "GroupAdd";
            this.GroupAdd.Size = new System.Drawing.Size(280, 248);
            this.GroupAdd.TabIndex = 6;
            this.GroupAdd.TabStop = false;
            this.GroupAdd.Text = "Добавить";
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel4.Location = new System.Drawing.Point(6, 162);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(102, 20);
            this.customLabel4.TabIndex = 22;
            this.customLabel4.Text = "* Комиссия";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel3.Location = new System.Drawing.Point(6, 111);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(103, 20);
            this.customLabel3.TabIndex = 23;
            this.customLabel3.Text = "* Отчество";
            // 
            // fie_add_comissia
            // 
            this.fie_add_comissia.Location = new System.Drawing.Point(6, 185);
            this.fie_add_comissia.Name = "fie_add_comissia";
            this.fie_add_comissia.Size = new System.Drawing.Size(268, 20);
            this.fie_add_comissia.TabIndex = 20;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel2.Location = new System.Drawing.Point(6, 62);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(55, 20);
            this.customLabel2.TabIndex = 19;
            this.customLabel2.Text = "* Имя";
            // 
            // fie_add_otchestvo
            // 
            this.fie_add_otchestvo.Location = new System.Drawing.Point(6, 134);
            this.fie_add_otchestvo.Name = "fie_add_otchestvo";
            this.fie_add_otchestvo.Size = new System.Drawing.Size(268, 20);
            this.fie_add_otchestvo.TabIndex = 21;
            // 
            // fie_add_name
            // 
            this.fie_add_name.Location = new System.Drawing.Point(6, 85);
            this.fie_add_name.Name = "fie_add_name";
            this.fie_add_name.Size = new System.Drawing.Size(268, 20);
            this.fie_add_name.TabIndex = 18;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel1.Location = new System.Drawing.Point(6, 16);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(100, 20);
            this.customLabel1.TabIndex = 17;
            this.customLabel1.Text = "* Фамилия";
            // 
            // fie_add_familia
            // 
            this.fie_add_familia.Location = new System.Drawing.Point(6, 39);
            this.fie_add_familia.Name = "fie_add_familia";
            this.fie_add_familia.Size = new System.Drawing.Size(268, 20);
            this.fie_add_familia.TabIndex = 16;
            // 
            // But_Add
            // 
            this.But_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.But_Add.Location = new System.Drawing.Point(6, 211);
            this.But_Add.Name = "But_Add";
            this.But_Add.Size = new System.Drawing.Size(268, 27);
            this.But_Add.TabIndex = 4;
            this.But_Add.Text = "Добавить";
            this.But_Add.UseVisualStyleBackColor = false;
            this.But_Add.Click += new System.EventHandler(this.But_Add_Click);
            // 
            // Grid_Rieltors
            // 
            this.Grid_Rieltors.AllowUserToAddRows = false;
            this.Grid_Rieltors.AllowUserToDeleteRows = false;
            this.Grid_Rieltors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid_Rieltors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Rieltors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Grid_Rieltors.Location = new System.Drawing.Point(12, 266);
            this.Grid_Rieltors.MultiSelect = false;
            this.Grid_Rieltors.Name = "Grid_Rieltors";
            this.Grid_Rieltors.ReadOnly = true;
            this.Grid_Rieltors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Rieltors.Size = new System.Drawing.Size(840, 376);
            this.Grid_Rieltors.TabIndex = 5;
            this.Grid_Rieltors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Rieltors_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 81;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Имя";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 54;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Отчество";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 79;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Комиссия";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 83;
            // 
            // but_prev
            // 
            this.but_prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.but_prev.Location = new System.Drawing.Point(12, 687);
            this.but_prev.Name = "but_prev";
            this.but_prev.Size = new System.Drawing.Size(75, 23);
            this.but_prev.TabIndex = 10;
            this.but_prev.Text = "<- Назад";
            this.but_prev.UseVisualStyleBackColor = false;
            this.but_prev.Click += new System.EventHandler(this.but_prev_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wsr7.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(603, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // go_Supplies
            // 
            this.go_Supplies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.go_Supplies.Location = new System.Drawing.Point(632, 687);
            this.go_Supplies.Name = "go_Supplies";
            this.go_Supplies.Size = new System.Drawing.Size(107, 23);
            this.go_Supplies.TabIndex = 16;
            this.go_Supplies.Text = "Предложения";
            this.go_Supplies.UseVisualStyleBackColor = false;
            this.go_Supplies.Click += new System.EventHandler(this.go_Supplies_Click);
            // 
            // go_Demands
            // 
            this.go_Demands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.go_Demands.Location = new System.Drawing.Point(745, 687);
            this.go_Demands.Name = "go_Demands";
            this.go_Demands.Size = new System.Drawing.Size(107, 23);
            this.go_Demands.TabIndex = 15;
            this.go_Demands.Text = "Потребности";
            this.go_Demands.UseVisualStyleBackColor = false;
            this.go_Demands.Click += new System.EventHandler(this.go_Demands_Click);
            // 
            // RieltorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 718);
            this.Controls.Add(this.go_Supplies);
            this.Controls.Add(this.go_Demands);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_prev);
            this.Controls.Add(this.Fie_Search);
            this.Controls.Add(this.But_Dell);
            this.Controls.Add(this.GroupEdit);
            this.Controls.Add(this.GroupAdd);
            this.Controls.Add(this.Grid_Rieltors);
            this.Name = "RieltorsForm";
            this.Text = "Риелторы";
            this.GroupEdit.ResumeLayout(false);
            this.GroupEdit.PerformLayout();
            this.GroupAdd.ResumeLayout(false);
            this.GroupAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Rieltors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fie_Search;
        private CustomForms.CustomButton But_Dell;
        private System.Windows.Forms.GroupBox GroupEdit;
        private CustomForms.CustomButton But_Edit;
        private System.Windows.Forms.GroupBox GroupAdd;
        private CustomForms.CustomButton But_Add;
        private System.Windows.Forms.DataGridView Grid_Rieltors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private CustomForms.CustomButton but_prev;
        private CustomForms.CustomLabel customLabel4;
        private CustomForms.CustomLabel customLabel3;
        private System.Windows.Forms.TextBox fie_add_comissia;
        private CustomForms.CustomLabel customLabel2;
        private System.Windows.Forms.TextBox fie_add_otchestvo;
        private System.Windows.Forms.TextBox fie_add_name;
        private CustomForms.CustomLabel customLabel1;
        private System.Windows.Forms.TextBox fie_add_familia;
        private CustomForms.CustomLabel customLabel5;
        private System.Windows.Forms.TextBox fie_edit_familia;
        private CustomForms.CustomLabel customLabel6;
        private System.Windows.Forms.TextBox fie_edit_name;
        private CustomForms.CustomLabel customLabel7;
        private System.Windows.Forms.TextBox fie_edit_comissia;
        private CustomForms.CustomLabel customLabel8;
        private System.Windows.Forms.TextBox fie_edit_otchestvo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomForms.CustomButton go_Supplies;
        private CustomForms.CustomButton go_Demands;
    }
}