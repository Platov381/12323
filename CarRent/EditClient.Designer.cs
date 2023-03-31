namespace CarRent
{
    partial class EditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Passport = new System.Windows.Forms.TextBox();
            this.DrivingLicenseNum = new System.Windows.Forms.TextBox();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.AddClient_buttom = new System.Windows.Forms.Button();
            this.EditClient_buttom = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FirstSearch = new System.Windows.Forms.TextBox();
            this.LastSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ClientEdit_datagrid = new System.Windows.Forms.DataGridView();
            this.DelClient_buttom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientEdit_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пасспорт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Права";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Телефон";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(122, 35);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(180, 29);
            this.LastName.TabIndex = 5;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(122, 71);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(180, 29);
            this.FirstName.TabIndex = 6;
            // 
            // Passport
            // 
            this.Passport.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passport.Location = new System.Drawing.Point(122, 108);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(180, 29);
            this.Passport.TabIndex = 7;
            this.Passport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Passport_KeyPress);
            // 
            // DrivingLicenseNum
            // 
            this.DrivingLicenseNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrivingLicenseNum.Location = new System.Drawing.Point(122, 148);
            this.DrivingLicenseNum.Name = "DrivingLicenseNum";
            this.DrivingLicenseNum.Size = new System.Drawing.Size(180, 29);
            this.DrivingLicenseNum.TabIndex = 8;
            this.DrivingLicenseNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrivingLicenseNum_KeyPress);
            // 
            // PhoneNum
            // 
            this.PhoneNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNum.Location = new System.Drawing.Point(122, 186);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(180, 29);
            this.PhoneNum.TabIndex = 9;
            this.PhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNum_KeyPress);
            // 
            // AddClient_buttom
            // 
            this.AddClient_buttom.BackColor = System.Drawing.Color.Lime;
            this.AddClient_buttom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddClient_buttom.BackgroundImage")));
            this.AddClient_buttom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddClient_buttom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddClient_buttom.Location = new System.Drawing.Point(12, 440);
            this.AddClient_buttom.Name = "AddClient_buttom";
            this.AddClient_buttom.Size = new System.Drawing.Size(264, 55);
            this.AddClient_buttom.TabIndex = 10;
            this.AddClient_buttom.Text = "Добавить \r\nКлиента\r\n";
            this.AddClient_buttom.UseVisualStyleBackColor = false;
            this.AddClient_buttom.Click += new System.EventHandler(this.AddClient_buttom_Click);
            // 
            // EditClient_buttom
            // 
            this.EditClient_buttom.BackColor = System.Drawing.Color.Yellow;
            this.EditClient_buttom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditClient_buttom.BackgroundImage")));
            this.EditClient_buttom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditClient_buttom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditClient_buttom.Location = new System.Drawing.Point(282, 440);
            this.EditClient_buttom.Name = "EditClient_buttom";
            this.EditClient_buttom.Size = new System.Drawing.Size(243, 55);
            this.EditClient_buttom.TabIndex = 11;
            this.EditClient_buttom.Text = "Редактировать\r\nвыбранного клиента\r\n";
            this.EditClient_buttom.UseVisualStyleBackColor = false;
            this.EditClient_buttom.Click += new System.EventHandler(this.EditClient_buttom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(330, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Фильтр по имени:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(330, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Фильтр по фамилии:";
            // 
            // FirstSearch
            // 
            this.FirstSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstSearch.Location = new System.Drawing.Point(508, 340);
            this.FirstSearch.Name = "FirstSearch";
            this.FirstSearch.Size = new System.Drawing.Size(261, 29);
            this.FirstSearch.TabIndex = 14;
            this.FirstSearch.TextChanged += new System.EventHandler(this.FirstSearch_TextChanged);
            // 
            // LastSearch
            // 
            this.LastSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastSearch.Location = new System.Drawing.Point(508, 378);
            this.LastSearch.Name = "LastSearch";
            this.LastSearch.Size = new System.Drawing.Size(261, 29);
            this.LastSearch.TabIndex = 15;
            this.LastSearch.TextChanged += new System.EventHandler(this.LastSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(502, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Клиенты";
            // 
            // ClientEdit_datagrid
            // 
            this.ClientEdit_datagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientEdit_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientEdit_datagrid.Location = new System.Drawing.Point(335, 38);
            this.ClientEdit_datagrid.Name = "ClientEdit_datagrid";
            this.ClientEdit_datagrid.Size = new System.Drawing.Size(443, 280);
            this.ClientEdit_datagrid.TabIndex = 17;
            this.ClientEdit_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientEdit_datagrid_Click);
            this.ClientEdit_datagrid.Click += new System.EventHandler(this.ClientEdit_datagrid_Click);
            // 
            // DelClient_buttom
            // 
            this.DelClient_buttom.BackColor = System.Drawing.Color.Red;
            this.DelClient_buttom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelClient_buttom.BackgroundImage")));
            this.DelClient_buttom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DelClient_buttom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelClient_buttom.Location = new System.Drawing.Point(531, 440);
            this.DelClient_buttom.Name = "DelClient_buttom";
            this.DelClient_buttom.Size = new System.Drawing.Size(253, 55);
            this.DelClient_buttom.TabIndex = 18;
            this.DelClient_buttom.Text = "Удалить\r\nклиента\r\n";
            this.DelClient_buttom.UseVisualStyleBackColor = false;
            this.DelClient_buttom.Click += new System.EventHandler(this.DelClient_buttom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRent.Properties.Resources._1614546318_22_p_avto_na_belom_fone_25;
            this.pictureBox1.Location = new System.Drawing.Point(11, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(791, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DelClient_buttom);
            this.Controls.Add(this.ClientEdit_datagrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LastSearch);
            this.Controls.Add(this.FirstSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EditClient_buttom);
            this.Controls.Add(this.AddClient_buttom);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.DrivingLicenseNum);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditClient";
            this.Text = "Добавить/Редактивровать Клиента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditClient_FormClosed);
            this.Load += new System.EventHandler(this.EditClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientEdit_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.TextBox DrivingLicenseNum;
        private System.Windows.Forms.TextBox PhoneNum;
        private System.Windows.Forms.Button AddClient_buttom;
        private System.Windows.Forms.Button EditClient_buttom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FirstSearch;
        private System.Windows.Forms.TextBox LastSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ClientEdit_datagrid;
        private System.Windows.Forms.Button DelClient_buttom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}