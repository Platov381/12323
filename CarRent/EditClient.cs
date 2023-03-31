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
    public partial class EditClient : Form
    {
        public SqlConnection sqlConnection = null;
        public EditClient()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public void ClientTableUpdate()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT FirstName as N'Имя', LastName as N'Фамилия', Passport as N'Номер паспорта', DrivingLicenseNum as N'Номер водительских прав', PhoneNum as N'Номер', ClientsId as N'Номер клиента'  FROM Clients", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            ClientEdit_datagrid.DataSource = dataSet.Tables[0];
        }
        public bool isNotClear()
        {
            if (string.IsNullOrWhiteSpace(FirstName.Text) | string.IsNullOrWhiteSpace(LastName.Text) | string.IsNullOrWhiteSpace(Passport.Text) | string.IsNullOrWhiteSpace(DrivingLicenseNum.Text) | string.IsNullOrWhiteSpace(PhoneNum.Text))
            {
                return false;
            }
            return true;
        }
        private void EditClient_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentDB"].ConnectionString);
            sqlConnection.Open();
            ClientTableUpdate();
        }

        private void AddClient_buttom_Click(object sender, EventArgs e)
        {
            if (isNotClear())
            {
                SqlCommand command = new SqlCommand("INSERT INTO Clients (FirstName, LastName, DrivingLicenseNum, PhoneNum, Passport) VALUES (@FirstName, @LastName, @DrivingLicenseNum, @PhoneNum, @Passport)", sqlConnection);
                command.Parameters.AddWithValue("FirstName", FirstName.Text);
                command.Parameters.AddWithValue("LastName", LastName.Text);
                command.Parameters.AddWithValue("DrivingLicenseNum", DrivingLicenseNum.Text);
                command.Parameters.AddWithValue("PhoneNum", PhoneNum.Text);
                command.Parameters.AddWithValue("Passport", Passport.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Клиент добавлен!");
                }
                else
                {
                    MessageBox.Show("Клиент не добавлен!");
                }
                ClientTableUpdate();
            }
            else
            {
                MessageBox.Show("Вы вводите пустые значения");
            }
        }
        private void EditClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logins.mainForm.Show();
        }
        private void ClientEdit_datagrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClientEdit_datagrid.Rows[ClientEdit_datagrid.SelectedCells[0].RowIndex].Cells[5].Value != null)
                {
                    int ClientID = Convert.ToInt32(ClientEdit_datagrid.Rows[ClientEdit_datagrid.SelectedCells[0].RowIndex].Cells[5].Value);
                    FirstName.Text = Convert.ToString(ClientEdit_datagrid.Rows[ClientEdit_datagrid.SelectedCells[0].RowIndex].Cells[0].Value);
                    LastName.Text = Convert.ToString(ClientEdit_datagrid.Rows[ClientEdit_datagrid.SelectedCells[0].RowIndex].Cells[1].Value);
                    DrivingLicenseNum.Text = Convert.ToString(ClientEdit_datagrid.Rows[ClientEdit_datagrid.SelectedCells[0].RowIndex].Cells[3].Value);
                    PhoneNum.Text = Convert.ToString(ClientEdit_datagrid.Rows[ClientEdit_datagrid.SelectedCells[0].RowIndex].Cells[4].Value);
                    Passport.Text = Convert.ToString(ClientEdit_datagrid.Rows[ClientEdit_datagrid.SelectedCells[0].RowIndex].Cells[2].Value);
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

        private void EditClient_buttom_Click(object sender, EventArgs e)
        {
            int ClientID = Convert.ToInt32(ClientEdit_datagrid.Rows[ClientEdit_datagrid.SelectedCells[0].RowIndex].Cells[5].Value);
            SqlCommand command = new SqlCommand("update Clients Set FirstName = @FirstName, LastName = @LastName, DrivingLicenseNum = @DrivingLicenseNum, PhoneNum = @PhoneNum, Passport = @Passport where ClientsId = @ClientsId", sqlConnection);
            command.Parameters.AddWithValue("FirstName", FirstName.Text);
            command.Parameters.AddWithValue("LastName", LastName.Text);
            command.Parameters.AddWithValue("DrivingLicenseNum", DrivingLicenseNum.Text);
            command.Parameters.AddWithValue("PhoneNum", PhoneNum.Text);
            command.Parameters.AddWithValue("Passport", Passport.Text);
            command.Parameters.AddWithValue("ClientsId", ClientID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные о клиенте изменены!");
            }
            else
            {
                MessageBox.Show("Данные о клиенте не изменены!");
            }
            ClientTableUpdate();
        }
        private void Passport_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void DrivingLicenseNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void PhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void FirstSearch_TextChanged(object sender, EventArgs e)
        {
            if (LastSearch.Text == "")
            {
                (ClientEdit_datagrid.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%{FirstSearch.Text}%'";
            }
            else
            {
                (ClientEdit_datagrid.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%{FirstSearch.Text}%' and Фамилия LIKE '%{LastSearch.Text}%'";
            }
        }
        private void LastSearch_TextChanged(object sender, EventArgs e)
        {
            if (FirstSearch.Text == "")
            {
                (ClientEdit_datagrid.DataSource as DataTable).DefaultView.RowFilter = $"Фамилия LIKE '%{LastSearch.Text}%'";
            }
            else
            {
                (ClientEdit_datagrid.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%{FirstSearch.Text}%' and Фамилия LIKE '%{LastSearch.Text}%'";
            }
        }

        private void DelClient_buttom_Click(object sender, EventArgs e)
        {
            int ClientID = Convert.ToInt32(ClientEdit_datagrid.Rows[ClientEdit_datagrid.SelectedCells[0].RowIndex].Cells[5].Value);
            SqlCommand command = new SqlCommand("delete Clients where ClientsID = @ClientsID", sqlConnection);
            command.Parameters.AddWithValue("ClientsID", ClientID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Клиент удален!");
            }
            else
            {
                MessageBox.Show("Клиент не удален!");
            }
            ClientTableUpdate();
        }
    }
}
