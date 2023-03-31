using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RealtorAgency
{
    public partial class realtors : Form
    {
        public MainForm form1 = new MainForm();
        private SqlConnection sqlConnection = null;
        public realtors()
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

        private void realtors_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void realtors_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT id as N'№', login as N'Логин', password as N'Пароль', firstName as N'Имя', secondName as N'Фамилия', fatherName as N'Отчество', number as N'Номер телефона', email as N'Почта' FROM admins", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    int typeID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                    firstName.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value);
                    secondName.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value);
                    lastName.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value);
                    phone.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[6].Value);
                    mail.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[7].Value);
                    login.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value);
                    password.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value);

                }
                else
                {
                    MessageBox.Show("Вы не выбрали риэлтора!");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали риэлтора!");
            }
        }

        public bool isNotClear()
        {
            if (string.IsNullOrWhiteSpace(firstName.Text) | string.IsNullOrWhiteSpace(secondName.Text) | string.IsNullOrWhiteSpace(lastName.Text) | string.IsNullOrWhiteSpace(phone.Text) | string.IsNullOrWhiteSpace(mail.Text) | string.IsNullOrWhiteSpace(login.Text) | string.IsNullOrWhiteSpace(password.Text))
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNotClear())
            {
                SqlCommand command = new SqlCommand("INSERT INTO admins (firstName, secondName, fatherName, number, email, login, password) VALUES (@firstName, @secondName, @fatherName, @number, @email, @login, @password)", sqlConnection);
                command.Parameters.AddWithValue("firstName", firstName.Text);
                command.Parameters.AddWithValue("secondName", secondName.Text);
                command.Parameters.AddWithValue("fatherName", lastName.Text);
                command.Parameters.AddWithValue("number", phone.Text);
                command.Parameters.AddWithValue("email", mail.Text);
                command.Parameters.AddWithValue("login", login.Text);
                command.Parameters.AddWithValue("password", password.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Риэлтор добавлен!");
                }
                else
                {
                    MessageBox.Show("Риэлтор не добавлен!");
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
            int realtorID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("update admins Set firstName = @firstName, secondName = @secondName, fatherName = @fatherName, email  = @email, login  = @login, password  = @password where id = @realtorID", sqlConnection);
            command.Parameters.AddWithValue("firstName", firstName.Text);
            command.Parameters.AddWithValue("secondName", secondName.Text);
            command.Parameters.AddWithValue("fatherName", lastName.Text);
            command.Parameters.AddWithValue("phone", phone.Text);
            command.Parameters.AddWithValue("email", mail.Text);
            command.Parameters.AddWithValue("login", login.Text);
            command.Parameters.AddWithValue("password", password.Text);
            command.Parameters.AddWithValue("realtorID", realtorID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные о риэлторе изменены.");
            }
            else
            {
                MessageBox.Show("Данные о риэлторе не изменены.");
            }
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int realtorID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("delete admins where id = @realtorID", sqlConnection);
            command.Parameters.AddWithValue("realtorID", realtorID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Риэлтор удален!");
            }
            else
            {
                MessageBox.Show("Риэлтор не удален!");
            }
            loadData();
        }
    }
}
