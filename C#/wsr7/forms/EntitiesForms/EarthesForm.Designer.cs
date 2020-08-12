namespace wsr7.Forms.EntitiesForms
{
    partial class EarthesForm
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
            this.GroupEdit = new System.Windows.Forms.GroupBox();
            this.fie_edit_area = new System.Windows.Forms.TextBox();
            this.But_Edit = new wsr7.CustomForms.CustomButton();
            this.GroupAdd = new System.Windows.Forms.GroupBox();
            this.customLabel4 = new wsr7.CustomForms.CustomLabel();
            this.customLabel3 = new wsr7.CustomForms.CustomLabel();
            this.fie_add_house = new System.Windows.Forms.TextBox();
            this.customLabel2 = new wsr7.CustomForms.CustomLabel();
            this.fie_add_street = new System.Windows.Forms.TextBox();
            this.fie_add_city = new System.Windows.Forms.TextBox();
            this.customLabel1 = new wsr7.CustomForms.CustomLabel();
            this.fie_add_ploshad = new System.Windows.Forms.TextBox();
            this.But_Add = new wsr7.CustomForms.CustomButton();
            this.grid_earthes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_prev = new wsr7.CustomForms.CustomButton();
            this.But_Dell = new wsr7.CustomForms.CustomButton();
            this.customLabel9 = new wsr7.CustomForms.CustomLabel();
            this.fie_add_flat = new System.Windows.Forms.TextBox();
            this.customLabel10 = new wsr7.CustomForms.CustomLabel();
            this.fie_add_shirota = new System.Windows.Forms.TextBox();
            this.customLabel11 = new wsr7.CustomForms.CustomLabel();
            this.fie_add_dolgota = new System.Windows.Forms.TextBox();
            this.customLabel5 = new wsr7.CustomForms.CustomLabel();
            this.customLabel6 = new wsr7.CustomForms.CustomLabel();
            this.customLabel7 = new wsr7.CustomForms.CustomLabel();
            this.customLabel8 = new wsr7.CustomForms.CustomLabel();
            this.customLabel12 = new wsr7.CustomForms.CustomLabel();
            this.customLabel13 = new wsr7.CustomForms.CustomLabel();
            this.customLabel14 = new wsr7.CustomForms.CustomLabel();
            this.fie_edit_city = new System.Windows.Forms.TextBox();
            this.fie_edit_street = new System.Windows.Forms.TextBox();
            this.fie_edit_house = new System.Windows.Forms.TextBox();
            this.fie_edit_flat = new System.Windows.Forms.TextBox();
            this.fie_edit_shirota = new System.Windows.Forms.TextBox();
            this.fie_edit_dolgota = new System.Windows.Forms.TextBox();
            this.GroupEdit.SuspendLayout();
            this.GroupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_earthes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Fie_Search
            // 
            this.Fie_Search.Location = new System.Drawing.Point(11, 792);
            this.Fie_Search.Name = "Fie_Search";
            this.Fie_Search.Size = new System.Drawing.Size(842, 20);
            this.Fie_Search.TabIndex = 23;
            this.Fie_Search.TextChanged += new System.EventHandler(this.Fie_Search_TextChanged);
            // 
            // GroupEdit
            // 
            this.GroupEdit.Controls.Add(this.fie_edit_dolgota);
            this.GroupEdit.Controls.Add(this.fie_edit_shirota);
            this.GroupEdit.Controls.Add(this.fie_edit_flat);
            this.GroupEdit.Controls.Add(this.fie_edit_house);
            this.GroupEdit.Controls.Add(this.fie_edit_street);
            this.GroupEdit.Controls.Add(this.fie_edit_city);
            this.GroupEdit.Controls.Add(this.customLabel5);
            this.GroupEdit.Controls.Add(this.fie_edit_area);
            this.GroupEdit.Controls.Add(this.customLabel6);
            this.GroupEdit.Controls.Add(this.customLabel7);
            this.GroupEdit.Controls.Add(this.customLabel8);
            this.GroupEdit.Controls.Add(this.customLabel12);
            this.GroupEdit.Controls.Add(this.But_Edit);
            this.GroupEdit.Controls.Add(this.customLabel13);
            this.GroupEdit.Controls.Add(this.customLabel14);
            this.GroupEdit.Location = new System.Drawing.Point(297, 12);
            this.GroupEdit.Name = "GroupEdit";
            this.GroupEdit.Size = new System.Drawing.Size(280, 379);
            this.GroupEdit.TabIndex = 21;
            this.GroupEdit.TabStop = false;
            this.GroupEdit.Text = "Редактировать";
            // 
            // fie_edit_area
            // 
            this.fie_edit_area.Location = new System.Drawing.Point(6, 38);
            this.fie_edit_area.Name = "fie_edit_area";
            this.fie_edit_area.Size = new System.Drawing.Size(268, 20);
            this.fie_edit_area.TabIndex = 22;
            // 
            // But_Edit
            // 
            this.But_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.But_Edit.Location = new System.Drawing.Point(6, 345);
            this.But_Edit.Name = "But_Edit";
            this.But_Edit.Size = new System.Drawing.Size(268, 27);
            this.But_Edit.TabIndex = 5;
            this.But_Edit.Text = "Изменить";
            this.But_Edit.UseVisualStyleBackColor = false;
            this.But_Edit.Click += new System.EventHandler(this.But_Edit_Click);
            // 
            // GroupAdd
            // 
            this.GroupAdd.Controls.Add(this.customLabel11);
            this.GroupAdd.Controls.Add(this.fie_add_dolgota);
            this.GroupAdd.Controls.Add(this.customLabel10);
            this.GroupAdd.Controls.Add(this.fie_add_shirota);
            this.GroupAdd.Controls.Add(this.customLabel9);
            this.GroupAdd.Controls.Add(this.fie_add_flat);
            this.GroupAdd.Controls.Add(this.customLabel4);
            this.GroupAdd.Controls.Add(this.customLabel3);
            this.GroupAdd.Controls.Add(this.fie_add_house);
            this.GroupAdd.Controls.Add(this.customLabel2);
            this.GroupAdd.Controls.Add(this.fie_add_street);
            this.GroupAdd.Controls.Add(this.fie_add_city);
            this.GroupAdd.Controls.Add(this.customLabel1);
            this.GroupAdd.Controls.Add(this.fie_add_ploshad);
            this.GroupAdd.Controls.Add(this.But_Add);
            this.GroupAdd.Location = new System.Drawing.Point(11, 12);
            this.GroupAdd.Name = "GroupAdd";
            this.GroupAdd.Size = new System.Drawing.Size(280, 379);
            this.GroupAdd.TabIndex = 20;
            this.GroupAdd.TabStop = false;
            this.GroupAdd.Text = "Добавить";
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel4.Location = new System.Drawing.Point(6, 155);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(44, 20);
            this.customLabel4.TabIndex = 22;
            this.customLabel4.Text = "Дом";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel3.Location = new System.Drawing.Point(6, 108);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(61, 20);
            this.customLabel3.TabIndex = 23;
            this.customLabel3.Text = "Улица";
            // 
            // fie_add_house
            // 
            this.fie_add_house.Location = new System.Drawing.Point(6, 178);
            this.fie_add_house.Name = "fie_add_house";
            this.fie_add_house.Size = new System.Drawing.Size(268, 20);
            this.fie_add_house.TabIndex = 20;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel2.Location = new System.Drawing.Point(6, 61);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(61, 20);
            this.customLabel2.TabIndex = 19;
            this.customLabel2.Text = "Город";
            // 
            // fie_add_street
            // 
            this.fie_add_street.Location = new System.Drawing.Point(6, 131);
            this.fie_add_street.Name = "fie_add_street";
            this.fie_add_street.Size = new System.Drawing.Size(268, 20);
            this.fie_add_street.TabIndex = 21;
            // 
            // fie_add_city
            // 
            this.fie_add_city.Location = new System.Drawing.Point(6, 84);
            this.fie_add_city.Name = "fie_add_city";
            this.fie_add_city.Size = new System.Drawing.Size(268, 20);
            this.fie_add_city.TabIndex = 18;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel1.Location = new System.Drawing.Point(6, 16);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(89, 20);
            this.customLabel1.TabIndex = 17;
            this.customLabel1.Text = "Площадь";
            // 
            // fie_add_ploshad
            // 
            this.fie_add_ploshad.Location = new System.Drawing.Point(6, 39);
            this.fie_add_ploshad.Name = "fie_add_ploshad";
            this.fie_add_ploshad.Size = new System.Drawing.Size(268, 20);
            this.fie_add_ploshad.TabIndex = 16;
            // 
            // But_Add
            // 
            this.But_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.But_Add.Location = new System.Drawing.Point(6, 345);
            this.But_Add.Name = "But_Add";
            this.But_Add.Size = new System.Drawing.Size(268, 27);
            this.But_Add.TabIndex = 4;
            this.But_Add.Text = "Добавить";
            this.But_Add.UseVisualStyleBackColor = false;
            this.But_Add.Click += new System.EventHandler(this.But_Add_Click);
            // 
            // grid_earthes
            // 
            this.grid_earthes.AllowUserToAddRows = false;
            this.grid_earthes.AllowUserToDeleteRows = false;
            this.grid_earthes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_earthes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_earthes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.grid_earthes.Location = new System.Drawing.Point(11, 397);
            this.grid_earthes.MultiSelect = false;
            this.grid_earthes.Name = "grid_earthes";
            this.grid_earthes.ReadOnly = true;
            this.grid_earthes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_earthes.Size = new System.Drawing.Size(840, 376);
            this.grid_earthes.TabIndex = 19;
            this.grid_earthes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fie_add_flat_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Площадь";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 79;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Город";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 62;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Улица";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 64;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Дом";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 55;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Квартира";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Широта";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 70;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Долгота";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 75;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wsr7.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(602, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // but_prev
            // 
            this.but_prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.but_prev.Location = new System.Drawing.Point(11, 818);
            this.but_prev.Name = "but_prev";
            this.but_prev.Size = new System.Drawing.Size(75, 23);
            this.but_prev.TabIndex = 24;
            this.but_prev.Text = "<- Назад";
            this.but_prev.UseVisualStyleBackColor = false;
            this.but_prev.Click += new System.EventHandler(this.but_prev_Click);
            // 
            // But_Dell
            // 
            this.But_Dell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.But_Dell.Location = new System.Drawing.Point(583, 357);
            this.But_Dell.Name = "But_Dell";
            this.But_Dell.Size = new System.Drawing.Size(268, 27);
            this.But_Dell.TabIndex = 22;
            this.But_Dell.Text = "Удалить";
            this.But_Dell.UseVisualStyleBackColor = false;
            this.But_Dell.Click += new System.EventHandler(this.But_Dell_Click);
            // 
            // customLabel9
            // 
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel9.Location = new System.Drawing.Point(6, 202);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(90, 20);
            this.customLabel9.TabIndex = 25;
            this.customLabel9.Text = "Квартира";
            // 
            // fie_add_flat
            // 
            this.fie_add_flat.Location = new System.Drawing.Point(6, 225);
            this.fie_add_flat.Name = "fie_add_flat";
            this.fie_add_flat.Size = new System.Drawing.Size(268, 20);
            this.fie_add_flat.TabIndex = 24;
            // 
            // customLabel10
            // 
            this.customLabel10.AutoSize = true;
            this.customLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel10.Location = new System.Drawing.Point(6, 249);
            this.customLabel10.Name = "customLabel10";
            this.customLabel10.Size = new System.Drawing.Size(73, 20);
            this.customLabel10.TabIndex = 27;
            this.customLabel10.Text = "Широта";
            // 
            // fie_add_shirota
            // 
            this.fie_add_shirota.Location = new System.Drawing.Point(6, 272);
            this.fie_add_shirota.Name = "fie_add_shirota";
            this.fie_add_shirota.Size = new System.Drawing.Size(268, 20);
            this.fie_add_shirota.TabIndex = 26;
            // 
            // customLabel11
            // 
            this.customLabel11.AutoSize = true;
            this.customLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel11.Location = new System.Drawing.Point(6, 296);
            this.customLabel11.Name = "customLabel11";
            this.customLabel11.Size = new System.Drawing.Size(81, 20);
            this.customLabel11.TabIndex = 29;
            this.customLabel11.Text = "Долгота";
            // 
            // fie_add_dolgota
            // 
            this.fie_add_dolgota.Location = new System.Drawing.Point(6, 319);
            this.fie_add_dolgota.Name = "fie_add_dolgota";
            this.fie_add_dolgota.Size = new System.Drawing.Size(268, 20);
            this.fie_add_dolgota.TabIndex = 28;
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel5.Location = new System.Drawing.Point(6, 296);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(81, 20);
            this.customLabel5.TabIndex = 36;
            this.customLabel5.Text = "Долгота";
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel6.Location = new System.Drawing.Point(6, 249);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(73, 20);
            this.customLabel6.TabIndex = 35;
            this.customLabel6.Text = "Широта";
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel7.Location = new System.Drawing.Point(6, 202);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(90, 20);
            this.customLabel7.TabIndex = 34;
            this.customLabel7.Text = "Квартира";
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel8.Location = new System.Drawing.Point(6, 155);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(44, 20);
            this.customLabel8.TabIndex = 32;
            this.customLabel8.Text = "Дом";
            // 
            // customLabel12
            // 
            this.customLabel12.AutoSize = true;
            this.customLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel12.Location = new System.Drawing.Point(6, 108);
            this.customLabel12.Name = "customLabel12";
            this.customLabel12.Size = new System.Drawing.Size(61, 20);
            this.customLabel12.TabIndex = 33;
            this.customLabel12.Text = "Улица";
            // 
            // customLabel13
            // 
            this.customLabel13.AutoSize = true;
            this.customLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel13.Location = new System.Drawing.Point(6, 61);
            this.customLabel13.Name = "customLabel13";
            this.customLabel13.Size = new System.Drawing.Size(61, 20);
            this.customLabel13.TabIndex = 31;
            this.customLabel13.Text = "Город";
            // 
            // customLabel14
            // 
            this.customLabel14.AutoSize = true;
            this.customLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.customLabel14.Location = new System.Drawing.Point(6, 16);
            this.customLabel14.Name = "customLabel14";
            this.customLabel14.Size = new System.Drawing.Size(89, 20);
            this.customLabel14.TabIndex = 30;
            this.customLabel14.Text = "Площадь";
            // 
            // fie_edit_city
            // 
            this.fie_edit_city.Location = new System.Drawing.Point(6, 84);
            this.fie_edit_city.Name = "fie_edit_city";
            this.fie_edit_city.Size = new System.Drawing.Size(268, 20);
            this.fie_edit_city.TabIndex = 37;
            // 
            // fie_edit_street
            // 
            this.fie_edit_street.Location = new System.Drawing.Point(6, 132);
            this.fie_edit_street.Name = "fie_edit_street";
            this.fie_edit_street.Size = new System.Drawing.Size(268, 20);
            this.fie_edit_street.TabIndex = 38;
            // 
            // fie_edit_house
            // 
            this.fie_edit_house.Location = new System.Drawing.Point(6, 178);
            this.fie_edit_house.Name = "fie_edit_house";
            this.fie_edit_house.Size = new System.Drawing.Size(268, 20);
            this.fie_edit_house.TabIndex = 39;
            // 
            // fie_edit_flat
            // 
            this.fie_edit_flat.Location = new System.Drawing.Point(6, 226);
            this.fie_edit_flat.Name = "fie_edit_flat";
            this.fie_edit_flat.Size = new System.Drawing.Size(268, 20);
            this.fie_edit_flat.TabIndex = 40;
            // 
            // fie_edit_shirota
            // 
            this.fie_edit_shirota.Location = new System.Drawing.Point(6, 272);
            this.fie_edit_shirota.Name = "fie_edit_shirota";
            this.fie_edit_shirota.Size = new System.Drawing.Size(268, 20);
            this.fie_edit_shirota.TabIndex = 41;
            // 
            // fie_edit_dolgota
            // 
            this.fie_edit_dolgota.Location = new System.Drawing.Point(6, 319);
            this.fie_edit_dolgota.Name = "fie_edit_dolgota";
            this.fie_edit_dolgota.Size = new System.Drawing.Size(268, 20);
            this.fie_edit_dolgota.TabIndex = 42;
            // 
            // EarthesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 847);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_prev);
            this.Controls.Add(this.Fie_Search);
            this.Controls.Add(this.But_Dell);
            this.Controls.Add(this.GroupEdit);
            this.Controls.Add(this.GroupAdd);
            this.Controls.Add(this.grid_earthes);
            this.Name = "EarthesForm";
            this.Text = "Земли";
            this.GroupEdit.ResumeLayout(false);
            this.GroupEdit.PerformLayout();
            this.GroupAdd.ResumeLayout(false);
            this.GroupAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_earthes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomForms.CustomButton but_prev;
        private System.Windows.Forms.TextBox Fie_Search;
        private CustomForms.CustomButton But_Dell;
        private System.Windows.Forms.GroupBox GroupEdit;
        private System.Windows.Forms.TextBox fie_edit_area;
        private CustomForms.CustomButton But_Edit;
        private System.Windows.Forms.GroupBox GroupAdd;
        private CustomForms.CustomLabel customLabel4;
        private CustomForms.CustomLabel customLabel3;
        private System.Windows.Forms.TextBox fie_add_house;
        private CustomForms.CustomLabel customLabel2;
        private System.Windows.Forms.TextBox fie_add_street;
        private System.Windows.Forms.TextBox fie_add_city;
        private CustomForms.CustomLabel customLabel1;
        private System.Windows.Forms.TextBox fie_add_ploshad;
        private CustomForms.CustomButton But_Add;
        private System.Windows.Forms.DataGridView grid_earthes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private CustomForms.CustomLabel customLabel11;
        private System.Windows.Forms.TextBox fie_add_dolgota;
        private CustomForms.CustomLabel customLabel10;
        private System.Windows.Forms.TextBox fie_add_shirota;
        private CustomForms.CustomLabel customLabel9;
        private System.Windows.Forms.TextBox fie_add_flat;
        private System.Windows.Forms.TextBox fie_edit_dolgota;
        private System.Windows.Forms.TextBox fie_edit_shirota;
        private System.Windows.Forms.TextBox fie_edit_flat;
        private System.Windows.Forms.TextBox fie_edit_house;
        private System.Windows.Forms.TextBox fie_edit_street;
        private System.Windows.Forms.TextBox fie_edit_city;
        private CustomForms.CustomLabel customLabel5;
        private CustomForms.CustomLabel customLabel6;
        private CustomForms.CustomLabel customLabel7;
        private CustomForms.CustomLabel customLabel8;
        private CustomForms.CustomLabel customLabel12;
        private CustomForms.CustomLabel customLabel13;
        private CustomForms.CustomLabel customLabel14;
    }
}