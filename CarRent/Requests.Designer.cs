namespace CarRent
{
    partial class Requests
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
            this.Zapro = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Zaprosi_datagrid = new System.Windows.Forms.DataGridView();
            this.AddCar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Zaprosi_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Zapro
            // 
            this.Zapro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zapro.FormattingEnabled = true;
            this.Zapro.Location = new System.Drawing.Point(84, 36);
            this.Zapro.Name = "Zapro";
            this.Zapro.Size = new System.Drawing.Size(307, 29);
            this.Zapro.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 38;
            this.label9.Text = "Запрос:";
            // 
            // Zaprosi_datagrid
            // 
            this.Zaprosi_datagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Zaprosi_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Zaprosi_datagrid.Location = new System.Drawing.Point(12, 101);
            this.Zaprosi_datagrid.Name = "Zaprosi_datagrid";
            this.Zaprosi_datagrid.Size = new System.Drawing.Size(545, 291);
            this.Zaprosi_datagrid.TabIndex = 40;
            // 
            // AddCar_button
            // 
            this.AddCar_button.BackColor = System.Drawing.Color.Lime;
            this.AddCar_button.BackgroundImage = global::CarRent.Properties.Resources._2019_02_15_16_23_07;
            this.AddCar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddCar_button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCar_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddCar_button.Location = new System.Drawing.Point(397, 22);
            this.AddCar_button.Name = "AddCar_button";
            this.AddCar_button.Size = new System.Drawing.Size(160, 55);
            this.AddCar_button.TabIndex = 41;
            this.AddCar_button.Text = "Выполнить";
            this.AddCar_button.UseVisualStyleBackColor = false;
            this.AddCar_button.Click += new System.EventHandler(this.AddCar_button_Click);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(569, 404);
            this.Controls.Add(this.AddCar_button);
            this.Controls.Add(this.Zaprosi_datagrid);
            this.Controls.Add(this.Zapro);
            this.Controls.Add(this.label9);
            this.Name = "Requests";
            this.Text = "Запросы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Requests_FormClosed);
            this.Load += new System.EventHandler(this.Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Zaprosi_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Zapro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Zaprosi_datagrid;
        private System.Windows.Forms.Button AddCar_button;
    }
}