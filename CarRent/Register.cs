using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CarRent
{
    public partial class Register : Form
    {
        public SqlConnection sqlConnection = null;
        public static MainForm mainForm = new MainForm();
        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Regisrer_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentDB"].ConnectionString);
            sqlConnection.Open();
        }
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logins frm_logins = new Logins();
            frm_logins.Show();
            this.Hide();
        }

        private void Create_login_Click(object sender, EventArgs e)
        {
            if (FirstName_text.Text == "")
            {
                MessageBox.Show("Вы не ввели Имя!");
                return;
            }
            if (LastName_text.Text == "")
            {
                MessageBox.Show("Вы не ввели Фамилию!");
                return;
            }
            if (logreg_text.Text == "")
            {
                MessageBox.Show("Вы не ввели логин!");
                return;
            }
            if (passreg_text.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль!");
                return;
            }
            SqlCommand command = new SqlCommand("INSERT INTO Managers (login, password, FirstName, LastName) VALUES (@login, @password, @FirstName, @LastName)", sqlConnection);
            command.Parameters.AddWithValue("login", logreg_text.Text);
            command.Parameters.AddWithValue("password", passreg_text.Text);
            command.Parameters.AddWithValue("FirstName", FirstName_text.Text);
            command.Parameters.AddWithValue("LastName", LastName_text.Text);



            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Менеджер добавлен!");
            }
            else
            {
                MessageBox.Show("Менеджер не добавлен!");
            }
        }
    }
}
