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
    public partial class Requests : Form
    {
        public SqlConnection sqlConnection = null;
        public Requests()
        {
            InitializeComponent();
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentDB"].ConnectionString);
            Zapro.Items.Insert(0, "Цена < 5000");
            Zapro.Items.Insert(1, "Цена > 5000");
            Zapro.Items.Insert(2, "Упорядоченный список марок");
            Zapro.Items.Insert(3, "Цвет автомобиля Белый");
            Zapro.Items.Insert(4, "Список автомобиля кузова седан");
            Zapro.Items.Insert(5, "Упорядоченный список клиентов");
            Zapro.Items.Insert(6, "Аренда на 21.11.2022");
            Zapro.Items.Insert(7, "Договор на сумму 32000");
            Zapro.Items.Insert(8, "Клиент Раиль");
            Zapro.Items.Insert(9, "Вывести автомобили цена которых 18000");
            Zapro.Items.Insert(10, "Вывести автомобили бренда Lada");
        }

        private void Requests_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logins.mainForm.Show();
        }

        private void AddCar_button_Click(object sender, EventArgs e)
        {
            string Text = "";
            if (Zapro.Text == "Цена < 5000" ) 
            {
                Text = "Select * from Cars where Price < 5000";
            }
            else if (Zapro.Text =="Цена > 5000")
            {
                Text = "Select * from Cars where Price > 5000";
            }
            else if (Zapro.Text == "Упорядоченный список марок")
            {
                Text = "Select * from Cars ORDER BY Brand";
            }
            else if (Zapro.Text == "Цвет автомобиля Белый")
            {
                Text = "Select * from Cars where Color = N'Белый'";
            }
            else if (Zapro.Text == "Список автомобиля кузова седан")
            {
                Text = "Select * from Cars WHERE Body = N'Седан'";
            }
            else if (Zapro.Text == "Упорядоченный список клиентов")
            {
                Text = "Select * from Clients ORDER BY FirstName,LastName;";
            }
            else if (Zapro.Text == "Аренда на 21.11.2022")
            {
                Text = "Select * from Contracts where RentStart = '20221121'";
            }
            else if (Zapro.Text == "Договор на сумму 32000")
            {
                Text = "Select * from Contracts where Price = 32000";
            }
            else if (Zapro.Text == "Клиент Раиль")
            {
                Text = "Select * from Clients Where FirstName = N'Раиль'";
            }
            else if (Zapro.Text == "Вывести автомобили цена которых 18000")
            {
                Text = "Select * from Cars where Price = '18000'";
            }
            else if (Zapro.Text == "Вывести автомобили бренда Lada")
            {
                Text = "Select * from Cars where Brand = 'Lada'";
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Text, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            Zaprosi_datagrid.DataSource = dataSet.Tables[0];

        }
    }
}
