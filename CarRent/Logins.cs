using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CarRent
{
    public partial class Logins : Form
    {
        public SqlConnection sqlConnection = null;
        public static int ManagerID = 0;
        public static MainForm mainForm = new MainForm();
        public Logins()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Logins_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentDB"].ConnectionString);
            sqlConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (log_text.Text == "")
            {
                MessageBox.Show("Вы не ввели логин!");
                return;
            }
            if (pass_text.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль!");
                return;
            }
            SqlCommand sqlCommand = new SqlCommand($"Select ManagerId from Managers where Login Like '{log_text.Text}' and Password Like '{pass_text.Text}'", sqlConnection);
            if (sqlCommand.ExecuteScalar() == null)
            {
                MessageBox.Show("Логин или пароль неверны!");
            }
            else
            {
                ManagerID = Convert.ToInt32(sqlCommand.ExecuteScalar());

                mainForm.Show();
                this.Hide();
            }
        }

        private void Reg_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register frm_register = new Register();
            frm_register.Show();
            this.Hide();
        }
    }
}
