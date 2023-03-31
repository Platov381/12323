namespace RealtorAgency
{
    partial class Request
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
            this.requsts = new System.Windows.Forms.DataGridView();
            this.comboRequest = new System.Windows.Forms.ComboBox();
            this.buttonRequst = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requsts)).BeginInit();
            this.SuspendLayout();
            // 
            // requsts
            // 
            this.requsts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requsts.Location = new System.Drawing.Point(12, 39);
            this.requsts.Name = "requsts";
            this.requsts.Size = new System.Drawing.Size(959, 287);
            this.requsts.TabIndex = 15;
            // 
            // comboRequest
            // 
            this.comboRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRequest.FormattingEnabled = true;
            this.comboRequest.Location = new System.Drawing.Point(97, 11);
            this.comboRequest.Name = "comboRequest";
            this.comboRequest.Size = new System.Drawing.Size(377, 21);
            this.comboRequest.TabIndex = 16;
            this.comboRequest.SelectedIndexChanged += new System.EventHandler(this.comboRequest_SelectedIndexChanged);
            // 
            // buttonRequst
            // 
            this.buttonRequst.Location = new System.Drawing.Point(480, 11);
            this.buttonRequst.Name = "buttonRequst";
            this.buttonRequst.Size = new System.Drawing.Size(99, 23);
            this.buttonRequst.TabIndex = 17;
            this.buttonRequst.Text = "Выполнить";
            this.buttonRequst.UseVisualStyleBackColor = true;
            this.buttonRequst.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(726, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(592, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Запрос";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRequst);
            this.Controls.Add(this.comboRequest);
            this.Controls.Add(this.requsts);
            this.Name = "Request";
            this.Text = "Запросы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Request_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.requsts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView requsts;
        private System.Windows.Forms.ComboBox comboRequest;
        private System.Windows.Forms.Button buttonRequst;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}