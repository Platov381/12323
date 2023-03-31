namespace CarRent
{
    partial class Logins
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
            this.log_text = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.Reg_label = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // log_text
            // 
            this.log_text.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_text.Location = new System.Drawing.Point(66, 12);
            this.log_text.Name = "log_text";
            this.log_text.Size = new System.Drawing.Size(215, 30);
            this.log_text.TabIndex = 0;
            // 
            // pass_text
            // 
            this.pass_text.Font = new System.Drawing.Font("TeamViewer15", 15F, System.Drawing.FontStyle.Bold);
            this.pass_text.Location = new System.Drawing.Point(67, 53);
            this.pass_text.Name = "pass_text";
            this.pass_text.PasswordChar = '*';
            this.pass_text.Size = new System.Drawing.Size(215, 29);
            this.pass_text.TabIndex = 6;
            // 
            // Reg_label
            // 
            this.Reg_label.AutoSize = true;
            this.Reg_label.LinkColor = System.Drawing.Color.Black;
            this.Reg_label.Location = new System.Drawing.Point(99, 133);
            this.Reg_label.Name = "Reg_label";
            this.Reg_label.Size = new System.Drawing.Size(104, 13);
            this.Reg_label.TabIndex = 7;
            this.Reg_label.TabStop = true;
            this.Reg_label.Text = "Ещё нет аккаунта?";
            this.Reg_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Reg_label_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(176, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarRent.Properties.Resources.png_clipart_teplogidrostroy_password_manager_admin_icon_data_teplogidrostroy_PhotoRoom_png_PhotoRoom;
            this.pictureBox2.Location = new System.Drawing.Point(7, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRent.Properties.Resources.png_clipart_india_company_business_chief_executive_profile_building_company_PhotoRoom_png_PhotoRoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRent.Properties.Resources.Account_Login_Button_PNG_File1;
            this.pictureBox3.Location = new System.Drawing.Point(177, 87);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(301, 151);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.log_text);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Reg_label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Name = "Logins";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Logins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.LinkLabel Reg_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}