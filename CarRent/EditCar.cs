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
    public partial class EditCar : Form
    {
        public SqlConnection sqlConnection = null;
        public EditCar()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public void CarTableUpdate()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Brand as N'Марка', Model as N'Модель', Body as N'Тип кузова', Number as N'Номер', Color as N'Цвет', Price as N'Цена', CarsId as N'ID'  FROM Cars", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            CarEdit_datagrid.DataSource = dataSet.Tables[0];
        }
        public bool isNotClear()
        {
            if (string.IsNullOrWhiteSpace(Model.Text) | string.IsNullOrWhiteSpace(Brand.Text) | string.IsNullOrWhiteSpace(Body.Text) | string.IsNullOrWhiteSpace(Color.Text) | string.IsNullOrWhiteSpace(Number.Text) | string.IsNullOrWhiteSpace(Price.Text))
            {
                return false;
            }
            return true;
        }
        private void EditCar_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentDB"].ConnectionString);
            sqlConnection.Open();
            CarTableUpdate();
            Body.Items.Insert(0, "Универсал");
            Body.Items.Insert(1, "Универсал");
            Body.Items.Insert(2, "Внедорожник"); 
            Body.Items.Insert(3, "Cпорткар"); 
            Body.Items.Insert(4, "Хэтчбек");
            Body.Items.Insert(5, "Лифтбек");
            Body.Items.Insert(6, "Купе");
            Body.Items.Insert(7, "Лимузин");
            Body.Items.Insert(8, "Кабриолет");
            Body.Items.Insert(9, "Седан");
        }
        private void EditCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logins.mainForm.Show();
        }

        private void AddCar_button_Click(object sender, EventArgs e)
        {
            if (isNotClear())
            {
                SqlCommand command = new SqlCommand("INSERT INTO Cars (Brand, Model, Body, Color, Price, Number) VALUES (@Brand, @Model, @Body, @Color, @Price, @Number)", sqlConnection);
                command.Parameters.AddWithValue("Brand", Brand.Text);
                command.Parameters.AddWithValue("Model", Model.Text);
                command.Parameters.AddWithValue("Body", Body.Text);
                command.Parameters.AddWithValue("Color", Color.Text);
                command.Parameters.AddWithValue("Price", Price.Text);
                command.Parameters.AddWithValue("Number", Number.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Автомобиль добавлен!");
                }
                else
                {
                    MessageBox.Show("Автомобиль не добавлен!");
                }
                CarTableUpdate();
            }
            else
            {
                MessageBox.Show("Вы вводите пустые значения");
            }
        }

        private void EditCar_button_Click(object sender, EventArgs e)
        {
            int CarID = Convert.ToInt32(CarEdit_datagrid.Rows[CarEdit_datagrid.SelectedCells[0].RowIndex].Cells[6].Value);
            SqlCommand command = new SqlCommand("update Cars Set Brand = @Brand, Model = @Model, Body = @Body, Color = @Color, Price = @Price, Number = @Number where CarsId = @CarsId", sqlConnection);
            command.Parameters.AddWithValue("Brand", Brand.Text);
            command.Parameters.AddWithValue("Model", Model.Text);
            command.Parameters.AddWithValue("Body", Body.Text);
            command.Parameters.AddWithValue("Color", Color.Text);
            command.Parameters.AddWithValue("Price", Price.Text);
            command.Parameters.AddWithValue("Number", Number.Text);
            command.Parameters.AddWithValue("CarsId", CarID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные о машине изменены!");
            }
            else
            {
                MessageBox.Show("Данные о машине не изменены!");
            }
            CarTableUpdate();
        }
        private void CarEdit_datagrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (CarEdit_datagrid.Rows[CarEdit_datagrid.SelectedCells[0].RowIndex].Cells[6].Value != null)
                {
                    int ClientID = Convert.ToInt32(CarEdit_datagrid.Rows[CarEdit_datagrid.SelectedCells[0].RowIndex].Cells[6].Value);
                    Brand.Text = Convert.ToString(CarEdit_datagrid.Rows[CarEdit_datagrid.SelectedCells[0].RowIndex].Cells[0].Value);
                    Model.Text = Convert.ToString(CarEdit_datagrid.Rows[CarEdit_datagrid.SelectedCells[0].RowIndex].Cells[1].Value);
                    Body.Text = Convert.ToString(CarEdit_datagrid.Rows[CarEdit_datagrid.SelectedCells[0].RowIndex].Cells[2].Value);
                    Color.Text = Convert.ToString(CarEdit_datagrid.Rows[CarEdit_datagrid.SelectedCells[0].RowIndex].Cells[4].Value);
                    Price.Text = Convert.ToString(CarEdit_datagrid.Rows[CarEdit_datagrid.SelectedCells[0].RowIndex].Cells[5].Value);
                    Number.Text = Convert.ToString(CarEdit_datagrid.Rows[CarEdit_datagrid.SelectedCells[0].RowIndex].Cells[3].Value);
                }
                else
                {
                    MessageBox.Show("Вы не выбрали автомобиль");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали автомобиль");
            }
        }
        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void BrandSearch_TextChanged(object sender, EventArgs e)
        {
            if (ModelSearch.Text == "")
            {
                (CarEdit_datagrid.DataSource as DataTable).DefaultView.RowFilter = $"Марка LIKE '%{BrandSearch.Text}%'";
            }
            else
            {
                (CarEdit_datagrid.DataSource as DataTable).DefaultView.RowFilter = $"Марка LIKE '%{BrandSearch.Text}%' and Модель LIKE '%{ModelSearch.Text}%'";
            }
        }

        private void ModelSearch_TextChanged(object sender, EventArgs e)
        {
            if (BrandSearch.Text == "")
            {
                (CarEdit_datagrid.DataSource as DataTable).DefaultView.RowFilter = $"Модель LIKE '%{ModelSearch.Text}%'";
            }
            else
            {
                (CarEdit_datagrid.DataSource as DataTable).DefaultView.RowFilter = $"Марка LIKE '%{BrandSearch.Text}%' and Модель LIKE '%{ModelSearch.Text}%'";
            }
        }


        private void DelCar_Click(object sender, EventArgs e)
        {
            int CarID = Convert.ToInt32(CarEdit_datagrid.Rows[CarEdit_datagrid.SelectedCells[0].RowIndex].Cells[6].Value);
            SqlCommand command = new SqlCommand("delete cars where CarsId = @CarsId", sqlConnection);
            command.Parameters.AddWithValue("CarsId", CarID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Машина удалена!");
            }
            else
            {
                MessageBox.Show("Машина не удален!");
            }
            CarTableUpdate();
        }

    }
}
