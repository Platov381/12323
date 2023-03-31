using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CarRent
{
    public partial class MainForm : Form
    {
        public SqlConnection sqlConnection = null;
        public static int contractID;
        public static DateTime start;
        public static DateTime over;
        public static int price;
        bool openContract = false;
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public void ClientTableUpdate()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT FirstName as N'Имя', LastName as N'Фамилия', Passport as N'Номер паспорта', DrivingLicenseNum as N'Номер водительских прав', PhoneNum as N'Номер', ClientsId as N'Номер клиента'  FROM Clients", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            Clients_datagrid.DataSource = dataSet.Tables[0];
        }

        public void ContractTableUpdate(int ClientID)
        {
            int id = Logins.ManagerID;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select (select FirstName from Clients where ClientsId = {ClientID}) as N'Имя', (select LastName from Clients where ClientsId = {ClientID}) as N'Фамилия', (select Brand from Cars where CarsId = CarId) as N'Марка', (select Model from Cars where CarsId = CarId) as N'Модель', RentStart as N'Начало аренды', RentOver as N'Конец аренды', Price as N'Цена', ContractId as N'Номер контракта' from Contracts where ClientId = {ClientID} and ManagerId = {id}", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            Contracts_datagrid.DataSource = dataSet.Tables[0];
            openContract = true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentDB"].ConnectionString);
            sqlConnection.Open();
            int id = Logins.ManagerID;
            string FirstName = new SqlCommand($"Select FirstName from Managers where ManagerId = {id}", sqlConnection).ExecuteScalar().ToString();
            string LastName = new SqlCommand($"Select LastName from Managers where ManagerId = {id}", sqlConnection).ExecuteScalar().ToString();
            MessageBox.Show($"Приветстую вас!\n" + 
                $"Вы зашли под аккаунтом - {FirstName} {LastName}");
            ClientTableUpdate();
        }
        private void MainForm_Closing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void edit_contract_button_Click(object sender, EventArgs e)
        {
            EditContract editContract = new EditContract();
            editContract.Show();
            this.Hide();
        }
        private void edit_client_button_Click(object sender, EventArgs e)
        {
            EditClient editClient = new EditClient();
            editClient.Show();
            this.Hide();
        }

        private void show_contract_button_Click(object sender, EventArgs e)
        {
            if (openContract)
            {
                contractID = Convert.ToInt32(Contracts_datagrid.Rows[Contracts_datagrid.SelectedCells[0].RowIndex].Cells[7].Value);
                start = Convert.ToDateTime(Contracts_datagrid.Rows[Contracts_datagrid.SelectedCells[0].RowIndex].Cells[4].Value);
                over = Convert.ToDateTime(Contracts_datagrid.Rows[Contracts_datagrid.SelectedCells[0].RowIndex].Cells[5].Value);
                price = Convert.ToInt32(Contracts_datagrid.Rows[Contracts_datagrid.SelectedCells[0].RowIndex].Cells[6].Value);
                AboutContract aboutContract = new AboutContract();
                aboutContract.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Выберите контракт");
            }
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            ClientTableUpdate();
        }
        private void Clients_datagrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clients_datagrid.Rows[Clients_datagrid.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    int ClientID = Convert.ToInt32(Clients_datagrid.Rows[Clients_datagrid.SelectedCells[0].RowIndex].Cells[5].Value);
                    ContractTableUpdate(ClientID);
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

        private void edit_car_button_Click(object sender, EventArgs e)
        {
            EditCar editCar = new EditCar();
            editCar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Requests requests = new Requests();
            requests.Show();
            this.Hide();
        }
    }
}
