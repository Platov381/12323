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

namespace RealtorAgency
{
    public partial class Login : Form
    {
        private SqlConnection sqlConnection = null;

        public MainForm MainForm = new MainForm();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            BaseEdit sql = new BaseEdit();
            sqlConnection = sql.sqlConnection;

            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение не установлено.");
                return;
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            SqlCommand checkUser = new SqlCommand("SELECT* from admins where login='" + loginTextBox.Text + "' and password='" + passwordTextBox.Text + "'", sqlConnection);
            if (checkUser.ExecuteScalar() == null)
            {
                MessageBox.Show("Логин или пароль неверны.");
            }
            else
            {
                this.Hide();
                MainForm.Show();
            }
        }
    }
}
