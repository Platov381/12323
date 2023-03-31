using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CarRent
{
    public partial class AboutContract : Form
    {
        public SqlConnection sqlConnection = null;
        int newClient;
        int newCar;
        bool isYourContract;
        public AboutContract()
        {
            InitializeComponent();
        }
        public void SelectClients()
        {
            sqlConnection.Close();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentDB"].ConnectionString);
            sqlConnection.Open();
            string Sql = "select Passport from Clients";
            SqlCommand ClientCmd = new SqlCommand(Sql, sqlConnection);
            SqlDataReader ClientDR = ClientCmd.ExecuteReader();
            while (ClientDR.Read())
            {
                ClientCombo.Items.Add(ClientDR[0]);
            }
        }

        public void SelectCars()
        {
            sqlConnection.Close();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentDB"].ConnectionString);
            sqlConnection.Open();
            string Sql = "select Number from Cars";
            SqlCommand CarCMD = new SqlCommand(Sql, sqlConnection);
            SqlDataReader CarDR = CarCMD.ExecuteReader();
            while (CarDR.Read())
            {
                CarCombo.Items.Add(CarDR[0]);
            }
        }

        public void FillClient(int ID)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select * FROM Clients", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            ClientGrid.DataSource = dataSet.Tables[0];
            FirstName.Text = Convert.ToString(ClientGrid.Rows[ID - 1].Cells[1].Value);
            LastName.Text = Convert.ToString(ClientGrid.Rows[ID - 1].Cells[2].Value);
            DrivingLicenseNum.Text = Convert.ToString(ClientGrid.Rows[ID - 1].Cells[3].Value);
            PhoneNum.Text = Convert.ToString(ClientGrid.Rows[ID - 1].Cells[4].Value);
            Passport.Text = Convert.ToString(ClientGrid.Rows[ID - 1].Cells[5].Value);
            sqlDataAdapter = new SqlDataAdapter($"Select Passport as N'Номер пасспорта',FirstName as N'Имя', LastName as N'Фамилия' FROM Clients", sqlConnection);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            ClientGrid.DataSource = dataSet.Tables[0];
        }

        public void FillCar(int ID)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select * FROM Cars", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            CarGrid.DataSource = dataSet.Tables[0];
            Brand.Text = Convert.ToString(CarGrid.Rows[ID - 1].Cells[1].Value);
            Model.Text = Convert.ToString(CarGrid.Rows[ID - 1].Cells[2].Value);
            Body.Text = Convert.ToString(CarGrid.Rows[ID - 1].Cells[3].Value);
            Color.Text = Convert.ToString(CarGrid.Rows[ID - 1].Cells[4].Value);
            Price.Text = Convert.ToString(CarGrid.Rows[ID - 1].Cells[5].Value);
            Number.Text = Convert.ToString(CarGrid.Rows[ID - 1].Cells[6].Value);
            sqlDataAdapter = new SqlDataAdapter($"Select Number as N'Номер',Brand as N'Марка', Model as N'Модель' FROM Cars", sqlConnection);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            CarGrid.DataSource = dataSet.Tables[0];
        }

        public void FillManager(int ID)
        {
            string FirstName = new SqlCommand($"Select FirstName from Managers where ManagerId = {ID}", sqlConnection).ExecuteScalar().ToString();
            string LastName = new SqlCommand($"Select LastName from Managers where ManagerId = {ID}", sqlConnection).ExecuteScalar().ToString();
            Manager.Text = $"{FirstName} {LastName}";
        }
        public void FillTime(DateTime start, DateTime over)
        {
            RentStart.Value = start;
            RentEnd.Value = over;
        }

        private void EditCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (EditCheck.Checked)
            {
                if (isYourContract)
                {
                    ClientCombo.Enabled = true;
                    CarCombo.Enabled = true;
                    RentStart.Enabled = true;
                    RentEnd.Enabled = true;
                    ChangeContract.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Контракт подписан другим менеджером");
                    EditCheck.Checked = false;
                }
            }
            else
            {
                ClientCombo.Enabled = false;
                CarCombo.Enabled = false;
                RentStart.Enabled = false;
                RentEnd.Enabled = false;
                ChangeContract.Enabled = true;
            }
        }
        private void AboutContract_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logins.mainForm.Show();
        }
        private void AboutContract_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentDB"].ConnectionString);
            sqlConnection.Open();
            SelectClients();
            SelectCars();
            sqlConnection.Close();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentDB"].ConnectionString);
            sqlConnection.Open();
            int ClientID = Convert.ToInt32(new SqlCommand($"Select ClientId from Contracts where ContractId = {MainForm.contractID}", sqlConnection).ExecuteScalar());
            newClient = ClientID;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select Passport as N'Номер пасспорта',FirstName as N'Имя', LastName as N'Фамилия' FROM Clients", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            ClientGrid.DataSource = dataSet.Tables[0];
            int CarID = Convert.ToInt32(new SqlCommand($"Select CarId from Contracts where ContractId = {MainForm.contractID}", sqlConnection).ExecuteScalar());
            newCar = CarID;
            sqlDataAdapter = new SqlDataAdapter($"Select Number as N'Номер',Brand as N'Марка', Model as N'Модель', Price as N'Цена' FROM Cars", sqlConnection);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            CarGrid.DataSource = dataSet.Tables[0];
            FillClient(ClientID);
            FillCar(CarID);
            int ManagerID = Convert.ToInt32(new SqlCommand($"Select ManagerId from Contracts where ContractId = {MainForm.contractID}", sqlConnection).ExecuteScalar());
            if (ManagerID == Logins.ManagerID)
                isYourContract = true;
            else
                isYourContract = false;
            FillManager(ManagerID);
            FillTime(MainForm.start, MainForm.over);
            Sum.Text = Convert.ToString(MainForm.price);
        }

        private void ChangeContract_Click(object sender, EventArgs e)
        {
            if (CheckSum.Checked)
            {
                SqlCommand command = new SqlCommand("update Contracts Set CarId = @CarId, ClientId = @ClientId, RentStart = @RentStart, RentOver = @RentOver, Price = @Price where ContractId = @ContractId", sqlConnection);
                command.Parameters.AddWithValue("CarId", newCar);
                command.Parameters.AddWithValue("ClientId", newClient);
                command.Parameters.AddWithValue("RentStart", RentStart.Value);
                command.Parameters.AddWithValue("RentOver", RentEnd.Value);
                command.Parameters.AddWithValue("Price", Sum.Text);
                command.Parameters.AddWithValue("ContractId", MainForm.contractID);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные о контракте изменены!");
                }
                else
                {
                    MessageBox.Show("Данные о контракте не изменены!");
                }
            }
            else
            {
                MessageBox.Show("Сумма не расчитана");
            }
        }
        private void ClientCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select * FROM Clients", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            ClientGrid.DataSource = dataSet.Tables[0];
            string Pass = ClientCombo.Text;
            int id = 0;
            for (int i = 0; i < ClientGrid.Rows.Count - 1;)
            {
                if (Pass == Convert.ToString(ClientGrid.Rows[i].Cells[5].Value))
                {
                    id = i;
                    break;
                }
                else
                {
                    i++;
                }
            }
            FirstName.Text = Convert.ToString(ClientGrid.Rows[id].Cells[1].Value);
            LastName.Text = Convert.ToString(ClientGrid.Rows[id].Cells[2].Value);
            DrivingLicenseNum.Text = Convert.ToString(ClientGrid.Rows[id].Cells[3].Value);
            PhoneNum.Text = Convert.ToString(ClientGrid.Rows[id].Cells[4].Value);
            Passport.Text = Convert.ToString(ClientGrid.Rows[id].Cells[5].Value);
            newClient = id + 1;
            sqlDataAdapter = new SqlDataAdapter($"Select Passport as N'Номер пасспорта',FirstName as N'Имя', LastName as N'Фамилия' FROM Clients", sqlConnection);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            ClientGrid.DataSource = dataSet.Tables[0];
        }
        private void CheckSum_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckSum.Checked)
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select * FROM Cars", sqlConnection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                CarGrid.DataSource = dataSet.Tables[0];
                int RentPrice = (RentEnd.Value - RentStart.Value).Days + 1;
                RentPrice = RentPrice * Convert.ToInt32(CarGrid.Rows[newCar - 1].Cells[5].Value);
                Sum.Text = Convert.ToString(RentPrice);
                sqlDataAdapter = new SqlDataAdapter($"Select Number as N'Номер',Brand as N'Марка', Model as N'Модель', Price as N'Цена' FROM Cars", sqlConnection);
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                CarGrid.DataSource = dataSet.Tables[0];
            }
            else
            {
                Sum.Text = "Сумма не расчитана";
            }
        }
        private void CarCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select * FROM Cars", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            CarGrid.DataSource = dataSet.Tables[0];
            string Num = CarCombo.Text;
            int id = 0;
            for (int i = 0; i < CarGrid.Rows.Count - 1;)
            {
                if (Num == Convert.ToString(CarGrid.Rows[i].Cells[6].Value))
                {
                    id = i;
                    break;
                }
                else
                {
                    i++;
                }
            }
            Brand.Text = Convert.ToString(CarGrid.Rows[id].Cells[1].Value);
            Model.Text = Convert.ToString(CarGrid.Rows[id].Cells[2].Value);
            Body.Text = Convert.ToString(CarGrid.Rows[id].Cells[3].Value);
            Color.Text = Convert.ToString(CarGrid.Rows[id].Cells[4].Value);
            Price.Text = Convert.ToString(CarGrid.Rows[id].Cells[5].Value);
            Number.Text = Convert.ToString(CarGrid.Rows[id].Cells[6].Value);
            newCar = id + 1;
            sqlDataAdapter = new SqlDataAdapter($"Select Number as N'Номер',Brand as N'Марка', Model as N'Модель', Price as N'Цена' FROM Cars", sqlConnection);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            CarGrid.DataSource = dataSet.Tables[0];
        }
    }
}
