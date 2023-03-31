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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RealtorAgency
{
    public partial class typesObjects : Form
    {
        public MainForm form1 = new MainForm();
        private SqlConnection sqlConnection = null;
        public typesObjects()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void typesObjects_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void typesObjects_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void loadData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT id as N'№', name as N'Название типа недвижимости' FROM type", sqlConnection);
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
                    name.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value);

                }
                else
                {
                    MessageBox.Show("Вы не выбрали тип недвижимости");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали тип недвижимости");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int typeID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("update type Set name = @name where id = @typeID", sqlConnection);
            command.Parameters.AddWithValue("name", name.Text);
            command.Parameters.AddWithValue("typeID", typeID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные о типе недвижимости изменены!");
            }
            else
            {
                MessageBox.Show("Данные о типе недвижимости не изменены!");
            }
            loadData();
        }

        public bool isNotClear()
        {
            if (string.IsNullOrWhiteSpace(name.Text))
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNotClear())
            {
                SqlCommand command = new SqlCommand("INSERT INTO type (name) VALUES (@name)", sqlConnection);
                command.Parameters.AddWithValue("name", name.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Тип недвижимости добавлен!");
                }
                else
                {
                    MessageBox.Show("Тип недвижимости не добавлен!");
                }
                loadData();
            }
            else
            {
                MessageBox.Show("Вы вводите пустые значения");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int typeID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("delete type where id = @typeID", sqlConnection);
            command.Parameters.AddWithValue("typeID", typeID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Тип недвижимости удален!");
            }
            else
            {
                MessageBox.Show("Тип недвижимости не удален!");
            }
            loadData();
        }
    }
}
