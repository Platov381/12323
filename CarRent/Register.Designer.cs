namespace CarRent
{
    partial class Register
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
            this.passreg_text = new System.Windows.Forms.TextBox();
            this.log_label = new System.Windows.Forms.Label();
            this.pass_log = new System.Windows.Forms.Label();
            this.logreg_text = new System.Windows.Forms.TextBox();
            this.LastName_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName_text = new System.Windows.Forms.TextBox();
            this.Create_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passreg_text
            // 
            this.passreg_text.Font = new System.Drawing.Font("TeamViewer15", 15F, System.Drawing.FontStyle.Bold);
            this.passreg_text.Location = new System.Drawing.Point(93, 119);
            this.passreg_text.Name = "passreg_text";
            this.passreg_text.PasswordChar = '*';
            this.passreg_text.Size = new System.Drawing.Size(215, 29);
            this.passreg_text.TabIndex = 10;
            // 
            // log_label
            // 
            this.log_label.AutoSize = true;
            this.log_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_label.Location = new System.Drawing.Point(2, 86);
            this.log_label.Name = "log_label";
            this.log_label.Size = new System.Drawing.Size(65, 21);
            this.log_label.TabIndex = 9;
            this.log_label.Text = "Логин:";
            // 
            // pass_log
            // 
            this.pass_log.AutoSize = true;
            this.pass_log.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_log.Location = new System.Drawing.Point(2, 122);
            this.pass_log.Name = "pass_log";
            this.pass_log.Size = new System.Drawing.Size(73, 21);
            this.pass_log.TabIndex = 8;
            this.pass_log.Text = "Пароль:";
            // 
            // logreg_text
            // 
            this.logreg_text.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logreg_text.Location = new System.Drawing.Point(93, 83);
            this.logreg_text.Name = "logreg_text";
            this.logreg_text.Size = new System.Drawing.Size(215, 30);
            this.logreg_text.TabIndex = 7;
            // 
            // LastName_text
            // 
            this.LastName_text.Font = new System.Drawing.Font("TeamViewer15", 15F, System.Drawing.FontStyle.Bold);
            this.LastName_text.Location = new System.Drawing.Point(93, 48);
            this.LastName_text.Name = "LastName_text";
            this.LastName_text.Size = new System.Drawing.Size(215, 29);
            this.LastName_text.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Фамилия:";
            // 
            // FirstName_text
            // 
            this.FirstName_text.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName_text.Location = new System.Drawing.Point(93, 12);
            this.FirstName_text.Name = "FirstName_text";
            this.FirstName_text.Size = new System.Drawing.Size(215, 30);
            this.FirstName_text.TabIndex = 12;
            // 
            // Create_login
            // 
            this.Create_login.BackColor = System.Drawing.Color.Lime;
            this.Create_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create_login.Location = new System.Drawing.Point(161, 163);
            this.Create_login.Name = "Create_login";
            this.Create_login.Size = new System.Drawing.Size(96, 37);
            this.Create_login.TabIndex = 11;
            this.Create_login.Text = "Создать аккаунт";
            this.Create_login.UseVisualStyleBackColor = false;
            this.Create_login.Click += new System.EventHandler(this.Create_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRent.Properties.Resources.hochesh_delat_manikjur_na_professionalnom_urovne_i_imet_vozmozhnost_zarabotat_2_PhotoRoom_png_PhotoRoom;
            this.pictureBox1.Location = new System.Drawing.Point(133, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Create_login_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(324, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LastName_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstName_text);
            this.Controls.Add(this.Create_login);
            this.Controls.Add(this.passreg_text);
            this.Controls.Add(this.log_label);
            this.Controls.Add(this.pass_log);
            this.Controls.Add(this.logreg_text);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Regisrer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passreg_text;
        private System.Windows.Forms.Label log_label;
        private System.Windows.Forms.Label pass_log;
        private System.Windows.Forms.TextBox logreg_text;
        private System.Windows.Forms.Button Create_login;
        private System.Windows.Forms.TextBox LastName_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName_text;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}