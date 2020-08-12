namespace wsr7.Forms.EntitiesForms
{
    partial class DealsForm
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
            this.combo_types = new System.Windows.Forms.ComboBox();
            this.grid_Flats = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupEdit = new System.Windows.Forms.GroupBox();
            this.fie_edit_demand = new System.Windows.Forms.ComboBox();
            this.fie_edit_supply = new System.Windows.Forms.ComboBox();
            this.GroupAdd = new System.Windows.Forms.GroupBox();
            this.fie_add_demand = new System.Windows.Forms.ComboBox();
            this.fie_add_supply = new System.Windows.Forms.ComboBox();
            this.Fie_Search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_sbros = new wsr7.CustomForms.CustomButton();
            this.customLabel17 = new wsr7.CustomForms.CustomLabel();
            this.customLabel18 = new wsr7.CustomForms.CustomLabel();
            this.But_Edit = new wsr7.CustomForms.CustomButton();
            this.customLabel16 = new wsr7.CustomForms.CustomLabel();
            this.customLabel15 = new wsr7.CustomForms.CustomLabel();
            this.But_Add = new wsr7.CustomForms.CustomButton();
            this.but_prev = new wsr7.CustomForms.CustomButton();
            this.But_Dell = new wsr7.CustomForms.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Flats)).BeginInit();
            this.GroupEdit.SuspendLayout();
            this.GroupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_types
            // 
            this.combo_types.FormattingEnabled = true;
            this.combo_types.Items.AddRange(new object[] {
            "Дома",
            "Квартиры",
            "Земли",
            "Всё"});
            this.combo_types.Location = new System.Drawing.Point(603, 118);
            this.combo_types.Name = "combo_types";
            this.combo_types.Size = new System.Drawing.Size(251, 21);
            this.combo_types.TabIndex = 52;
            this.combo_types.SelectionChangeCommitted += new System.EventHandler(this.combo_types_SelectionChangeCommitted);
            // 
            // grid_Flats
            // 
            this.grid_Flats.AllowUserToAddRows = false;
            this.grid_Flats.AllowUserToDeleteRows = false;
            this.grid_Flats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_Flats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Flats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.cc1,
            this.Column2});
            this.grid_Flats.Location = new System.Drawing.Point(14, 200);
            this.grid_Flats.MultiSelect = false;
            this.grid_Flats.Name = "grid_Flats";
            this.grid_Flats.ReadOnly = true;
            this.grid_Flats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Flats.Size = new System.Drawing.Size(840, 376);
            this.grid_Flats.TabIndex = 51;
            this.grid_Flats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Flats_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // cc1
            // 
            this.cc1.HeaderText = "Потребность";
            this.cc1.Name = "cc1";
            this.cc1.ReadOnly = true;
            this.cc1.Width = 98;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Предложение";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 102;
            // 
            // GroupEdit
            // 
            this.GroupEdit.Controls.Add(this.fie_edit_demand);
            this.GroupEdit.Controls.Add(this.fie_edit_supply);
            this.GroupEdit.Controls.Add(this.customLabel17);
            this.GroupEdit.Controls.Add(this.customLabel18);
            this.GroupEdit.Controls.Add(this.But_Edit);
            this.GroupEdit.Location = new System.Drawing.Point(298, 12);
            this.GroupEdit.Name = "GroupEdit";
            this.GroupEdit.Size = new System.Drawing.Size(280, 152);
            this.GroupEdit.TabIndex = 50;
            this.GroupEdit.TabStop = false;
            this.GroupEdit.Text = "Редактировать";
            // 
            // fie_edit_demand
            // 
            this.fie_edit_demand.FormattingEnabled = true;
            this.fie_edit_demand.Location = new System.Drawing.Point(10, 85);
            this.fie_edit_demand.Name = "fie_edit_demand";
            this.fie_edit_demand.Size = new System.Drawing.Size(264, 21);
            this.fie_edit_demand.TabIndex = 37;
            this.fie_edit_demand.SelectionChangeCommitted += new System.EventHandler(this.fie_edit_supply_SelectionChangeCommitted);
            // 
            // fie_edit_supply
            // 
            this.fie_edit_supply.FormattingEnabled = true;
            this.fie_edit_supply.Location = new System.Drawing.Point(10, 39);
            this.fie_edit_supply.Name = "fie_edit_supply";
            this.fie_edit_supply.Size = new System.Drawing.Size(264, 21);
            this.fie_edit_supply.TabIndex = 35;
            this.fie_edit_supply.SelectionChangeCommitted += new System.EventHandler(this.fie_edit_supply_SelectionChangeCommitted);
            // 
            // GroupAdd
            // 
            this.GroupAdd.Controls.Add(this.fie_add_demand);
            this.GroupAdd.Controls.Add(this.fie_add_supply);
            this.GroupAdd.Controls.Add(this.customLabel16);
            this.GroupAdd.Controls.Add(this.customLabel15);
            this.GroupAdd.Controls.Add(this.But_Add);
            this.GroupAdd.Location = new System.Drawing.Point(12, 12);
            this.GroupAdd.Name = "GroupAdd";
            this.GroupAdd.Size = new System.Drawing.Size(280, 152);
            this.GroupAdd.TabIndex = 49;
            this.GroupAdd.TabStop = false;
            this.GroupAdd.Text = "Добавить";
            // 
            // fie_add_demand
            // 
            this.fie_add_demand.FormattingEnabled = true;
            this.fie_add_demand.Location = new System.Drawing.Point(10, 83);
            this.fie_add_demand.Name = "fie_add_demand";
            this.fie_add_demand.Size = new System.Drawing.Size(264, 21);
            this.fie_add_demand.TabIndex = 34;
            this.fie_add_demand.SelectionChangeCommitted += new System.EventHandler(this.fie_add_demand_SelectionChangeCommitted);
            // 
            // fie_add_supply
            // 
            this.fie_add_supply.FormattingEnabled = true;
            this.fie_add_supply.Location = new System.Drawing.Point(10, 39);
            this.fie_add_supply.Name = "fie_add_supply";
            this.fie_add_supply.Size = new System.Drawing.Size(264, 21);
            this.fie_add_supply.TabIndex = 33;
            this.fie_add_supply.SelectionChangeCommitted += new System.EventHandler(this.fie_add_demand_SelectionChangeCommitted);
            // 
            // Fie_Search
            // 
            this.Fie_Search.Location = new System.Drawing.Point(14, 595);
            this.Fie_Search.Name = "Fie_Search";
            this.Fie_Search.Size = new System.Drawing.Size(842, 20);
            this.Fie_Search.TabIndex = 46;
            this.Fie_Search.TextChanged += new System.EventHandler(this.Fie_Search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wsr7.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(603, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // but_sbros
            // 
            this.but_sbros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.but_sbros.Location = new System.Drawing.Point(18, 167);
            this.but_sbros.Name = "but_sbros";
            this.but_sbros.Size = new System.Drawing.Size(554, 27);
            this.but_sbros.TabIndex = 35;
            this.but_sbros.Text = "Сбросить поля";
            this.but_sbros.UseVisualStyleBackColor = false;
            this.but_sbros.Click += new System.EventHandler(this.refreshAllFies_changebox);
            // 
            // customLabel17
            // 
            this.customLabel17.AutoSize = true;
            this.customLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel17.Location = new System.Drawing.Point(6, 62);
            this.customLabel17.Name = "customLabel17";
            this.customLabel17.Size = new System.Drawing.Size(121, 20);
            this.customLabel17.TabIndex = 36;
            this.customLabel17.Text = "Потребность";
            // 
            // customLabel18
            // 
            this.customLabel18.AutoSize = true;
            this.customLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel18.Location = new System.Drawing.Point(6, 16);
            this.customLabel18.Name = "customLabel18";
            this.customLabel18.Size = new System.Drawing.Size(127, 20);
            this.customLabel18.TabIndex = 34;
            this.customLabel18.Text = "Предложение";
            // 
            // But_Edit
            // 
            this.But_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.But_Edit.Location = new System.Drawing.Point(6, 110);
            this.But_Edit.Name = "But_Edit";
            this.But_Edit.Size = new System.Drawing.Size(268, 27);
            this.But_Edit.TabIndex = 5;
            this.But_Edit.Text = "Изменить";
            this.But_Edit.UseVisualStyleBackColor = false;
            this.But_Edit.Click += new System.EventHandler(this.But_Edit_Click);
            // 
            // customLabel16
            // 
            this.customLabel16.AutoSize = true;
            this.customLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel16.Location = new System.Drawing.Point(6, 62);
            this.customLabel16.Name = "customLabel16";
            this.customLabel16.Size = new System.Drawing.Size(121, 20);
            this.customLabel16.TabIndex = 32;
            this.customLabel16.Text = "Потребность";
            // 
            // customLabel15
            // 
            this.customLabel15.AutoSize = true;
            this.customLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel15.Location = new System.Drawing.Point(6, 16);
            this.customLabel15.Name = "customLabel15";
            this.customLabel15.Size = new System.Drawing.Size(127, 20);
            this.customLabel15.TabIndex = 30;
            this.customLabel15.Text = "Предложение";
            // 
            // But_Add
            // 
            this.But_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.But_Add.Location = new System.Drawing.Point(6, 110);
            this.But_Add.Name = "But_Add";
            this.But_Add.Size = new System.Drawing.Size(268, 27);
            this.But_Add.TabIndex = 4;
            this.But_Add.Text = "Добавить";
            this.But_Add.UseVisualStyleBackColor = false;
            this.But_Add.Click += new System.EventHandler(this.But_Add_Click);
            // 
            // but_prev
            // 
            this.but_prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.but_prev.Location = new System.Drawing.Point(14, 621);
            this.but_prev.Name = "but_prev";
            this.but_prev.Size = new System.Drawing.Size(75, 23);
            this.but_prev.TabIndex = 47;
            this.but_prev.Text = "<- Назад";
            this.but_prev.UseVisualStyleBackColor = false;
            this.but_prev.Click += new System.EventHandler(this.but_prev_Click);
            // 
            // But_Dell
            // 
            this.But_Dell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.But_Dell.Location = new System.Drawing.Point(603, 167);
            this.But_Dell.Name = "But_Dell";
            this.But_Dell.Size = new System.Drawing.Size(251, 27);
            this.But_Dell.TabIndex = 45;
            this.But_Dell.Text = "Удалить";
            this.But_Dell.UseVisualStyleBackColor = false;
            this.But_Dell.Click += new System.EventHandler(this.But_Dell_Click_1);
            // 
            // DealsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 658);
            this.Controls.Add(this.but_sbros);
            this.Controls.Add(this.combo_types);
            this.Controls.Add(this.grid_Flats);
            this.Controls.Add(this.GroupEdit);
            this.Controls.Add(this.GroupAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_prev);
            this.Controls.Add(this.Fie_Search);
            this.Controls.Add(this.But_Dell);
            this.Name = "DealsForm";
            this.Text = "DealsForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Flats)).EndInit();
            this.GroupEdit.ResumeLayout(false);
            this.GroupEdit.PerformLayout();
            this.GroupAdd.ResumeLayout(false);
            this.GroupAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_types;
        private System.Windows.Forms.DataGridView grid_Flats;
        private System.Windows.Forms.GroupBox GroupEdit;
        private CustomForms.CustomLabel customLabel17;
        private CustomForms.CustomLabel customLabel18;
        private CustomForms.CustomButton But_Edit;
        private System.Windows.Forms.GroupBox GroupAdd;
        private CustomForms.CustomLabel customLabel16;
        private CustomForms.CustomButton But_Add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomForms.CustomButton but_prev;
        private System.Windows.Forms.TextBox Fie_Search;
        private CustomForms.CustomButton But_Dell;
        private System.Windows.Forms.ComboBox fie_edit_demand;
        private System.Windows.Forms.ComboBox fie_edit_supply;
        private System.Windows.Forms.ComboBox fie_add_demand;
        private System.Windows.Forms.ComboBox fie_add_supply;
        private CustomForms.CustomLabel customLabel15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private CustomForms.CustomButton but_sbros;
    }
}