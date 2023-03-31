namespace CarRent
{
    partial class EditContract
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstSearch = new System.Windows.Forms.TextBox();
            this.LastSearch = new System.Windows.Forms.TextBox();
            this.BrandSearch = new System.Windows.Forms.TextBox();
            this.ModelSearch = new System.Windows.Forms.TextBox();
            this.ClientGrid = new System.Windows.Forms.DataGridView();
            this.CarGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RentStart = new System.Windows.Forms.DateTimePicker();
            this.RentEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.TextBox();
            this.EnterContract = new System.Windows.Forms.Button();
            this.CheckPrice = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(489, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фильтр по модели:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(489, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фильтр по марке:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фильтр по фамилии:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Фильтр по имени:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(659, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Автомобили";
            // 
            // FirstSearch
            // 
            this.FirstSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstSearch.Location = new System.Drawing.Point(188, 56);
            this.FirstSearch.Name = "FirstSearch";
            this.FirstSearch.Size = new System.Drawing.Size(278, 29);
            this.FirstSearch.TabIndex = 6;
            this.FirstSearch.TextChanged += new System.EventHandler(this.FirstSearch_TextChanged);
            // 
            // LastSearch
            // 
            this.LastSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastSearch.Location = new System.Drawing.Point(188, 97);
            this.LastSearch.Name = "LastSearch";
            this.LastSearch.Size = new System.Drawing.Size(278, 29);
            this.LastSearch.TabIndex = 7;
            this.LastSearch.TextChanged += new System.EventHandler(this.LastSearch_TextChanged);
            // 
            // BrandSearch
            // 
            this.BrandSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrandSearch.Location = new System.Drawing.Point(656, 56);
            this.BrandSearch.Name = "BrandSearch";
            this.BrandSearch.Size = new System.Drawing.Size(287, 29);
            this.BrandSearch.TabIndex = 8;
            this.BrandSearch.TextChanged += new System.EventHandler(this.BrandSearch_TextChanged);
            // 
            // ModelSearch
            // 
            this.ModelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelSearch.Location = new System.Drawing.Point(656, 97);
            this.ModelSearch.Name = "ModelSearch";
            this.ModelSearch.Size = new System.Drawing.Size(287, 29);
            this.ModelSearch.TabIndex = 9;
            this.ModelSearch.TextChanged += new System.EventHandler(this.ModelSearch_TextChanged);
            // 
            // ClientGrid
            // 
            this.ClientGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGrid.Location = new System.Drawing.Point(12, 132);
            this.ClientGrid.Name = "ClientGrid";
            this.ClientGrid.Size = new System.Drawing.Size(461, 183);
            this.ClientGrid.TabIndex = 10;
            this.ClientGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGrid_CellContentClick);
            // 
            // CarGrid
            // 
            this.CarGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGrid.Location = new System.Drawing.Point(489, 132);
            this.CarGrid.Name = "CarGrid";
            this.CarGrid.Size = new System.Drawing.Size(461, 183);
            this.CarGrid.TabIndex = 11;
            this.CarGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarGrid_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(70, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Начало аренды:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(70, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Конец аренды:";
            // 
            // RentStart
            // 
            this.RentStart.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RentStart.Location = new System.Drawing.Point(211, 379);
            this.RentStart.Name = "RentStart";
            this.RentStart.Size = new System.Drawing.Size(200, 20);
            this.RentStart.TabIndex = 14;
            // 
            // RentEnd
            // 
            this.RentEnd.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RentEnd.Location = new System.Drawing.Point(211, 411);
            this.RentEnd.Name = "RentEnd";
            this.RentEnd.Size = new System.Drawing.Size(200, 20);
            this.RentEnd.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(612, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "К оплате:";
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.SystemColors.Control;
            this.Sum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum.Location = new System.Drawing.Point(703, 382);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(178, 29);
            this.Sum.TabIndex = 17;
            this.Sum.Text = "Сумма не расчитана";
            // 
            // EnterContract
            // 
            this.EnterContract.BackColor = System.Drawing.Color.Lime;
            this.EnterContract.BackgroundImage = global::CarRent.Properties.Resources._2019_02_15_16_23_07;
            this.EnterContract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnterContract.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterContract.Location = new System.Drawing.Point(616, 430);
            this.EnterContract.Name = "EnterContract";
            this.EnterContract.Size = new System.Drawing.Size(265, 66);
            this.EnterContract.TabIndex = 18;
            this.EnterContract.Text = "Заключить \r\nдоговор";
            this.EnterContract.UseVisualStyleBackColor = false;
            this.EnterContract.Click += new System.EventHandler(this.EnterContract_Click);
            // 
            // CheckPrice
            // 
            this.CheckPrice.AutoSize = true;
            this.CheckPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPrice.Location = new System.Drawing.Point(616, 343);
            this.CheckPrice.Name = "CheckPrice";
            this.CheckPrice.Size = new System.Drawing.Size(161, 25);
            this.CheckPrice.TabIndex = 19;
            this.CheckPrice.Text = "Рассчитать цену";
            this.CheckPrice.UseVisualStyleBackColor = true;
            this.CheckPrice.CheckedChanged += new System.EventHandler(this.CheckPrice_CheckedChanged);
            // 
            // EditContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 510);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckPrice);
            this.Controls.Add(this.EnterContract);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RentEnd);
            this.Controls.Add(this.RentStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CarGrid);
            this.Controls.Add(this.ClientGrid);
            this.Controls.Add(this.ModelSearch);
            this.Controls.Add(this.BrandSearch);
            this.Controls.Add(this.LastSearch);
            this.Controls.Add(this.FirstSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditContract";
            this.Text = "Добавить/Редактировать договор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditContract_FormClosed);
            this.Load += new System.EventHandler(this.EditContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FirstSearch;
        private System.Windows.Forms.TextBox LastSearch;
        private System.Windows.Forms.TextBox BrandSearch;
        private System.Windows.Forms.TextBox ModelSearch;
        private System.Windows.Forms.DataGridView ClientGrid;
        private System.Windows.Forms.DataGridView CarGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker RentStart;
        private System.Windows.Forms.DateTimePicker RentEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.Button EnterContract;
        private System.Windows.Forms.CheckBox CheckPrice;
    }
}