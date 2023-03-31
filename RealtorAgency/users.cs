using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Diagnostics;
using System.Reflection;

namespace RealtorAgency
{
    public partial class users : Form
    {
        public MainForm form1 = new MainForm();
        private SqlConnection sqlConnection = null;
        public users()
        {
            InitializeComponent();

            BaseEdit sql = new BaseEdit();
            sqlConnection = sql.sqlConnection;

            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение не установлено.");
                return;
            }
        }

        private void users_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void users_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    int userID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                    firstName.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value);
                    secondName.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value);
                    fatherName.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value);
                    phone.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value);
                    email.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value);
                    passport.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[6].Value);

                }
                else
                {
                    MessageBox.Show("Вы не выбрали пользователя");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали пользователя");
            }
        }

        public bool isNotClear()
        {
            if (string.IsNullOrWhiteSpace(firstName.Text) | string.IsNullOrWhiteSpace(secondName.Text) | string.IsNullOrWhiteSpace(fatherName.Text) | string.IsNullOrWhiteSpace(phone.Text) | string.IsNullOrWhiteSpace(email.Text) | string.IsNullOrWhiteSpace(passport.Text))
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNotClear())
            {
                SqlCommand command = new SqlCommand("INSERT INTO users (firstName, secondName, fatherName, number, email, passport) VALUES (@firstName, @secondName, @fatherName, @number, @email, @passport)", sqlConnection);
                command.Parameters.AddWithValue("firstName", firstName.Text);
                command.Parameters.AddWithValue("secondName", secondName.Text);
                command.Parameters.AddWithValue("fatherName", fatherName.Text);
                command.Parameters.AddWithValue("number", phone.Text);
                command.Parameters.AddWithValue("email", email.Text);
                command.Parameters.AddWithValue("passport", passport.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Пользователь добавлен!");
                }
                else
                {
                    MessageBox.Show("Пользователь не добавлен!");
                }
                loadData();
            }
            else
            {
                MessageBox.Show("Вы вводите пустые значения");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("update users Set firstName = @firstName, secondName = @secondName, fatherName = @fatherName, email  = @email, passport  = @passport where id = @userID", sqlConnection);
            command.Parameters.AddWithValue("firstName", firstName.Text);
            command.Parameters.AddWithValue("secondName", secondName.Text);
            command.Parameters.AddWithValue("fatherName", fatherName.Text);
            command.Parameters.AddWithValue("phone", phone.Text);
            command.Parameters.AddWithValue("email", email.Text);
            command.Parameters.AddWithValue("passport", passport.Text);
            command.Parameters.AddWithValue("userID", userID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные о Пользователе изменены!");
            }
            else
            {
                MessageBox.Show("Данные о Пользователе не изменены!");
            }
            loadData();
        }

        private void loadData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT id as N'Номер пользователя', secondName as N'Фамилия', firstName as N'Имя', fatherName as N'Отчество', number as N'Номер', email as N'Почта', passport as N'Паспорт' FROM users", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("delete users where id = @userID", sqlConnection);
            command.Parameters.AddWithValue("userID", userID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пользователь удален!");
            }
            else
            {
                MessageBox.Show("Пользователь не удален!");
            }
            loadData();
        }
    }
}
