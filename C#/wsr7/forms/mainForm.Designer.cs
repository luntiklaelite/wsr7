namespace wsr7
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_goClients = new System.Windows.Forms.Button();
            this.but_goRieltors = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_goFlats = new System.Windows.Forms.Button();
            this.but_goHouses = new System.Windows.Forms.Button();
            this.but_goEarth = new System.Windows.Forms.Button();
            this.but_goSupplies = new System.Windows.Forms.Button();
            this.but_goDemands = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_goClients
            // 
            this.but_goClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.but_goClients.Location = new System.Drawing.Point(13, 114);
            this.but_goClients.Name = "but_goClients";
            this.but_goClients.Size = new System.Drawing.Size(247, 34);
            this.but_goClients.TabIndex = 1;
            this.but_goClients.Text = "Клиенты";
            this.but_goClients.UseVisualStyleBackColor = false;
            this.but_goClients.Click += new System.EventHandler(this.but_goClients_Click);
            // 
            // but_goRieltors
            // 
            this.but_goRieltors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.but_goRieltors.Location = new System.Drawing.Point(12, 154);
            this.but_goRieltors.Name = "but_goRieltors";
            this.but_goRieltors.Size = new System.Drawing.Size(248, 34);
            this.but_goRieltors.TabIndex = 2;
            this.but_goRieltors.Text = "Риелторы";
            this.but_goRieltors.UseVisualStyleBackColor = false;
            this.but_goRieltors.Click += new System.EventHandler(this.but_goRieltors_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wsr7.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // but_goFlats
            // 
            this.but_goFlats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.but_goFlats.Location = new System.Drawing.Point(12, 194);
            this.but_goFlats.Name = "but_goFlats";
            this.but_goFlats.Size = new System.Drawing.Size(248, 34);
            this.but_goFlats.TabIndex = 4;
            this.but_goFlats.Text = "Квартиры";
            this.but_goFlats.UseVisualStyleBackColor = false;
            this.but_goFlats.Click += new System.EventHandler(this.but_goFlats_Click);
            // 
            // but_goHouses
            // 
            this.but_goHouses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.but_goHouses.Location = new System.Drawing.Point(12, 234);
            this.but_goHouses.Name = "but_goHouses";
            this.but_goHouses.Size = new System.Drawing.Size(248, 34);
            this.but_goHouses.TabIndex = 5;
            this.but_goHouses.Text = "Дома";
            this.but_goHouses.UseVisualStyleBackColor = false;
            this.but_goHouses.Click += new System.EventHandler(this.but_goHouses_Click);
            // 
            // but_goEarth
            // 
            this.but_goEarth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.but_goEarth.Location = new System.Drawing.Point(12, 274);
            this.but_goEarth.Name = "but_goEarth";
            this.but_goEarth.Size = new System.Drawing.Size(248, 34);
            this.but_goEarth.TabIndex = 6;
            this.but_goEarth.Text = "Земли";
            this.but_goEarth.UseVisualStyleBackColor = false;
            this.but_goEarth.Click += new System.EventHandler(this.but_goEarth_Click);
            // 
            // but_goSupplies
            // 
            this.but_goSupplies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.but_goSupplies.Location = new System.Drawing.Point(12, 314);
            this.but_goSupplies.Name = "but_goSupplies";
            this.but_goSupplies.Size = new System.Drawing.Size(248, 34);
            this.but_goSupplies.TabIndex = 7;
            this.but_goSupplies.Text = "Предложения";
            this.but_goSupplies.UseVisualStyleBackColor = false;
            this.but_goSupplies.Click += new System.EventHandler(this.but_goSupplies_Click);
            // 
            // but_goDemands
            // 
            this.but_goDemands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.but_goDemands.Location = new System.Drawing.Point(12, 354);
            this.but_goDemands.Name = "but_goDemands";
            this.but_goDemands.Size = new System.Drawing.Size(248, 34);
            this.but_goDemands.TabIndex = 8;
            this.but_goDemands.Text = "Потребности";
            this.but_goDemands.UseVisualStyleBackColor = false;
            this.but_goDemands.Click += new System.EventHandler(this.but_goDemands_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(12, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сделки";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_goDemands);
            this.Controls.Add(this.but_goSupplies);
            this.Controls.Add(this.but_goEarth);
            this.Controls.Add(this.but_goHouses);
            this.Controls.Add(this.but_goFlats);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_goRieltors);
            this.Controls.Add(this.but_goClients);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_goClients;
        private System.Windows.Forms.Button but_goRieltors;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button but_goFlats;
        private System.Windows.Forms.Button but_goHouses;
        private System.Windows.Forms.Button but_goEarth;
        private System.Windows.Forms.Button but_goSupplies;
        private System.Windows.Forms.Button but_goDemands;
        private System.Windows.Forms.Button button1;
    }
}

