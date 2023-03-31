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

namespace CarRent
{
    public partial class EditContract : Form
    {
        public SqlConnection sqlConnection = null;
        public EditContract()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void EditContract_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logins.mainForm.Show();
        }
        public void ClientTableUpdate()
         {
             SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT FirstName as N'Имя', LastName as N'Фамилия', Passport as N'Номер паспорта', DrivingLicenseNum as N'Номер водительских прав', PhoneNum as N'Номер', ClientsId as N'Номер клиента'  FROM Clients", sqlConnection);
             DataSet dataSet = new DataSet();
             sqlDataAdapter.Fill(dataSet);
             ClientGrid.DataSource = dataSet.Tables[0];
         }

         public void CarTableUpdate()
         {
             SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Brand as N'Марка', Model as N'Модель', Body as N'Тип кузова', Number as N'Номер', Color as N'Цвет', Price as N'Цена', CarsId as N'ID'  FROM Cars", sqlConnection);
             DataSet dataSet = new DataSet();
             sqlDataAdapter.Fill(dataSet);
             CarGrid.DataSource = dataSet.Tables[0];
         }
        
        private void EditContract_Load(object sender, EventArgs e)
         {
             sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentDB"].ConnectionString);
             sqlConnection.Open();
             ClientTableUpdate();
             CarTableUpdate();
         }
        private void ClientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (CarGrid.Rows[CarGrid.SelectedCells[0].RowIndex].Cells[5].Value != null)
                {
                }
                else
                {
                    MessageBox.Show("Вы не выбрали клиента");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали клиента");
            }
        }
        private void CarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (CarGrid.Rows[CarGrid.SelectedCells[0].RowIndex].Cells[6].Value != null)
                {
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

        private void EnterContract_Click(object sender, EventArgs e)
        {
            if (ClientGrid.Rows[ClientGrid.SelectedCells[0].RowIndex].Cells[0].Value != null & CarGrid.Rows[CarGrid.SelectedCells[0].RowIndex].Cells[0].Value != null)
            {
                if (CheckPrice.Checked)
                {
                    int ClientID = Convert.ToInt32(ClientGrid.Rows[ClientGrid.SelectedCells[0].RowIndex].Cells[5].Value);
                    int CarID = Convert.ToInt32(CarGrid.Rows[CarGrid.SelectedCells[0].RowIndex].Cells[6].Value);

                    SqlCommand command = new SqlCommand("insert into Contracts(ClientId, CarId, ManagerId, RentStart, RentOver, Price) values(@ClientId, @CarId, @ManagerId, @RentStart, @RentOver, @Price)", sqlConnection);
                    command.Parameters.AddWithValue("ClientId", ClientID);
                    command.Parameters.AddWithValue("CarId", CarID);
                    command.Parameters.AddWithValue("ManagerId", Logins.ManagerID);
                    command.Parameters.AddWithValue("RentStart", RentStart.Value);
                    command.Parameters.AddWithValue("RentOver", RentEnd.Value);
                    command.Parameters.AddWithValue("Price", Convert.ToInt32(Sum.Text));
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Контракт добавлен!");
                    }
                    else
                    {
                        MessageBox.Show("Контракт не добавлен!");
                    }
                }
                else
                {
                    MessageBox.Show("Расчитайте сумму контракта");
                }
            }
            else
            {
                MessageBox.Show("Не выбран клиент и автомобиль");
            }
        }

        private void CheckPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPrice.Checked)
            {
                int RentPrice = (RentEnd.Value - RentStart.Value).Days + 1;
                RentPrice = RentPrice * Convert.ToInt32(CarGrid.Rows[CarGrid.SelectedCells[0].RowIndex].Cells[5].Value);
                Sum.Text = Convert.ToString(RentPrice);
            }
            else
            {
                Sum.Text = "Сумма не расчитана";
            }
        }
        private void FirstSearch_TextChanged(object sender, EventArgs e)
        {
            if (LastSearch.Text == "")
            {
                (ClientGrid.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%{FirstSearch.Text}%'";
            }
            else
            {
                (ClientGrid.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%{FirstSearch.Text}%' and Фамилия LIKE '%{LastSearch.Text}%'";
            }
        }

        private void LastSearch_TextChanged(object sender, EventArgs e)
        {
            if (FirstSearch.Text == "")
            {
                (ClientGrid.DataSource as DataTable).DefaultView.RowFilter = $"Фамилия LIKE '%{LastSearch.Text}%'";
            }
            else
            {
                (ClientGrid.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%{FirstSearch.Text}%' and Фамилия LIKE '%{LastSearch.Text}%'";
            }
        }

        private void BrandSearch_TextChanged(object sender, EventArgs e)
        {
            if (ModelSearch.Text == "")
            {
                (CarGrid.DataSource as DataTable).DefaultView.RowFilter = $"Марка LIKE '%{BrandSearch.Text}%'";
            }
            else
            {
                (CarGrid.DataSource as DataTable).DefaultView.RowFilter = $"Марка LIKE '%{BrandSearch.Text}%' and Модель LIKE '%{ModelSearch.Text}%'";
            }
        }

        private void ModelSearch_TextChanged(object sender, EventArgs e)
        {
            if (BrandSearch.Text == "")
            {
                (CarGrid.DataSource as DataTable).DefaultView.RowFilter = $"Модель LIKE '%{ModelSearch.Text}%'";
            }
            else
            {
                (CarGrid.DataSource as DataTable).DefaultView.RowFilter = $"Марка LIKE '%{BrandSearch.Text}%' and Модель LIKE '%{ModelSearch.Text}%'";
            }
        }
    }
}
