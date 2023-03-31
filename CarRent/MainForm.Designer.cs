namespace CarRent
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clients_datagrid = new System.Windows.Forms.DataGridView();
            this.Contracts_datagrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.show_contract_button = new System.Windows.Forms.Button();
            this.edit_contract_button = new System.Windows.Forms.Button();
            this.edit_client_button = new System.Windows.Forms.Button();
            this.edit_car_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Clients_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contracts_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(591, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(512, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Договоры с клиентами";
            // 
            // Clients_datagrid
            // 
            this.Clients_datagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clients_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clients_datagrid.Location = new System.Drawing.Point(366, 43);
            this.Clients_datagrid.Name = "Clients_datagrid";
            this.Clients_datagrid.Size = new System.Drawing.Size(564, 183);
            this.Clients_datagrid.TabIndex = 2;
            this.Clients_datagrid.Click += new System.EventHandler(this.Clients_datagrid_Click);
            // 
            // Contracts_datagrid
            // 
            this.Contracts_datagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contracts_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contracts_datagrid.Location = new System.Drawing.Point(366, 272);
            this.Contracts_datagrid.Name = "Contracts_datagrid";
            this.Contracts_datagrid.Size = new System.Drawing.Size(569, 160);
            this.Contracts_datagrid.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(33, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Запросы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // show_contract_button
            // 
            this.show_contract_button.BackColor = System.Drawing.Color.Yellow;
            this.show_contract_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_contract_button.BackgroundImage")));
            this.show_contract_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show_contract_button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_contract_button.ForeColor = System.Drawing.Color.Black;
            this.show_contract_button.Location = new System.Drawing.Point(33, 270);
            this.show_contract_button.Name = "show_contract_button";
            this.show_contract_button.Size = new System.Drawing.Size(287, 56);
            this.show_contract_button.TabIndex = 7;
            this.show_contract_button.Text = "Посмотреть/Изменить \r\nДоговор\r\n";
            this.show_contract_button.UseVisualStyleBackColor = false;
            this.show_contract_button.Click += new System.EventHandler(this.show_contract_button_Click);
            // 
            // edit_contract_button
            // 
            this.edit_contract_button.BackColor = System.Drawing.Color.Lime;
            this.edit_contract_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_contract_button.BackgroundImage")));
            this.edit_contract_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_contract_button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_contract_button.ForeColor = System.Drawing.Color.Black;
            this.edit_contract_button.Location = new System.Drawing.Point(33, 188);
            this.edit_contract_button.Name = "edit_contract_button";
            this.edit_contract_button.Size = new System.Drawing.Size(287, 61);
            this.edit_contract_button.TabIndex = 6;
            this.edit_contract_button.Text = "Добавить новый\r\nДоговор\r\n";
            this.edit_contract_button.UseVisualStyleBackColor = false;
            this.edit_contract_button.Click += new System.EventHandler(this.edit_contract_button_Click);
            // 
            // edit_client_button
            // 
            this.edit_client_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_client_button.BackgroundImage")));
            this.edit_client_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_client_button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_client_button.ForeColor = System.Drawing.Color.Black;
            this.edit_client_button.Location = new System.Drawing.Point(33, 108);
            this.edit_client_button.Name = "edit_client_button";
            this.edit_client_button.Size = new System.Drawing.Size(287, 58);
            this.edit_client_button.TabIndex = 5;
            this.edit_client_button.Text = "Добавить/Редактировать\r\nКлиента\r\n\r\n";
            this.edit_client_button.UseVisualStyleBackColor = true;
            this.edit_client_button.Click += new System.EventHandler(this.edit_client_button_Click);
            // 
            // edit_car_button
            // 
            this.edit_car_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_car_button.BackgroundImage")));
            this.edit_car_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_car_button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_car_button.ForeColor = System.Drawing.Color.Black;
            this.edit_car_button.Location = new System.Drawing.Point(33, 31);
            this.edit_car_button.Name = "edit_car_button";
            this.edit_car_button.Size = new System.Drawing.Size(287, 56);
            this.edit_car_button.TabIndex = 4;
            this.edit_car_button.Text = "Добавить/Редактировать Автомобиль\r\n";
            this.edit_car_button.UseVisualStyleBackColor = true;
            this.edit_car_button.Click += new System.EventHandler(this.edit_car_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(951, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.show_contract_button);
            this.Controls.Add(this.edit_contract_button);
            this.Controls.Add(this.edit_client_button);
            this.Controls.Add(this.edit_car_button);
            this.Controls.Add(this.Contracts_datagrid);
            this.Controls.Add(this.Clients_datagrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Автопрокат \"Lightning\"";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Clients_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contracts_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Clients_datagrid;
        private System.Windows.Forms.DataGridView Contracts_datagrid;
        private System.Windows.Forms.Button edit_car_button;
        private System.Windows.Forms.Button edit_client_button;
        private System.Windows.Forms.Button edit_contract_button;
        private System.Windows.Forms.Button show_contract_button;
        private System.Windows.Forms.Button button1;
    }
}