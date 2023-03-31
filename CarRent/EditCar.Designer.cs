namespace CarRent
{
    partial class EditCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCar));
            this.CarEdit_datagrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.ModelSearch = new System.Windows.Forms.TextBox();
            this.BrandSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.ComboBox();
            this.Brand = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DelCar = new System.Windows.Forms.Button();
            this.EditCar_button = new System.Windows.Forms.Button();
            this.AddCar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarEdit_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CarEdit_datagrid
            // 
            this.CarEdit_datagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CarEdit_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarEdit_datagrid.Location = new System.Drawing.Point(333, 44);
            this.CarEdit_datagrid.Name = "CarEdit_datagrid";
            this.CarEdit_datagrid.Size = new System.Drawing.Size(443, 280);
            this.CarEdit_datagrid.TabIndex = 35;
            this.CarEdit_datagrid.Click += new System.EventHandler(this.CarEdit_datagrid_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(476, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 31);
            this.label8.TabIndex = 34;
            this.label8.Text = "Автомобили";
            // 
            // ModelSearch
            // 
            this.ModelSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelSearch.Location = new System.Drawing.Point(505, 383);
            this.ModelSearch.Name = "ModelSearch";
            this.ModelSearch.Size = new System.Drawing.Size(261, 29);
            this.ModelSearch.TabIndex = 33;
            this.ModelSearch.TextChanged += new System.EventHandler(this.ModelSearch_TextChanged);
            // 
            // BrandSearch
            // 
            this.BrandSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrandSearch.Location = new System.Drawing.Point(505, 345);
            this.BrandSearch.Name = "BrandSearch";
            this.BrandSearch.Size = new System.Drawing.Size(261, 29);
            this.BrandSearch.TabIndex = 32;
            this.BrandSearch.TextChanged += new System.EventHandler(this.BrandSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(327, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Фильтр по модели:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(327, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Фильтр по марке:";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(119, 233);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(180, 29);
            this.Price.TabIndex = 27;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(119, 195);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(180, 29);
            this.Number.TabIndex = 26;
            this.Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // Color
            // 
            this.Color.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color.Location = new System.Drawing.Point(119, 155);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(180, 29);
            this.Color.TabIndex = 25;
            // 
            // Model
            // 
            this.Model.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model.Location = new System.Drawing.Point(119, 79);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(180, 29);
            this.Model.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Цвет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Марка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(21, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "Кузов";
            // 
            // Body
            // 
            this.Body.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Body.FormattingEnabled = true;
            this.Body.Location = new System.Drawing.Point(119, 118);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(180, 29);
            this.Body.TabIndex = 37;
            // 
            // Brand
            // 
            this.Brand.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brand.Location = new System.Drawing.Point(119, 39);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(180, 29);
            this.Brand.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRent.Properties.Resources.mercedes_PNG80143;
            this.pictureBox1.Location = new System.Drawing.Point(12, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // DelCar
            // 
            this.DelCar.BackColor = System.Drawing.Color.Red;
            this.DelCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelCar.BackgroundImage")));
            this.DelCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DelCar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelCar.Location = new System.Drawing.Point(101, 439);
            this.DelCar.Name = "DelCar";
            this.DelCar.Size = new System.Drawing.Size(221, 55);
            this.DelCar.TabIndex = 39;
            this.DelCar.Text = "Удалить\r\nАвтомобиль\r\n\r\n";
            this.DelCar.UseVisualStyleBackColor = false;
            this.DelCar.Click += new System.EventHandler(this.DelCar_Click);
            // 
            // EditCar_button
            // 
            this.EditCar_button.BackColor = System.Drawing.Color.Yellow;
            this.EditCar_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditCar_button.BackgroundImage")));
            this.EditCar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditCar_button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCar_button.Location = new System.Drawing.Point(331, 439);
            this.EditCar_button.Name = "EditCar_button";
            this.EditCar_button.Size = new System.Drawing.Size(221, 55);
            this.EditCar_button.TabIndex = 29;
            this.EditCar_button.Text = "Редактировать\r\nВыбранный автомобиль\r\n\r\n";
            this.EditCar_button.UseVisualStyleBackColor = false;
            this.EditCar_button.Click += new System.EventHandler(this.EditCar_button_Click);
            // 
            // AddCar_button
            // 
            this.AddCar_button.BackColor = System.Drawing.Color.Lime;
            this.AddCar_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddCar_button.BackgroundImage")));
            this.AddCar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddCar_button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCar_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddCar_button.Location = new System.Drawing.Point(560, 439);
            this.AddCar_button.Name = "AddCar_button";
            this.AddCar_button.Size = new System.Drawing.Size(221, 55);
            this.AddCar_button.TabIndex = 28;
            this.AddCar_button.Text = "Добавить \r\nАвтомобиль\r\n\r\n";
            this.AddCar_button.UseVisualStyleBackColor = false;
            this.AddCar_button.Click += new System.EventHandler(this.AddCar_button_Click);
            // 
            // EditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(790, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.DelCar);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CarEdit_datagrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ModelSearch);
            this.Controls.Add(this.BrandSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EditCar_button);
            this.Controls.Add(this.AddCar_button);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCar";
            this.Text = "Добавить/Редактировать машину";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditCar_FormClosed);
            this.Load += new System.EventHandler(this.EditCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarEdit_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CarEdit_datagrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ModelSearch;
        private System.Windows.Forms.TextBox BrandSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditCar_button;
        private System.Windows.Forms.Button AddCar_button;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Color;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Body;
        private System.Windows.Forms.Button DelCar;
        private System.Windows.Forms.TextBox Brand;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}