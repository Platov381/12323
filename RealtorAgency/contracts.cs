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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RealtorAgency
{
    public partial class contracts : Form
    {
        public MainForm form1 = new MainForm();
        private SqlConnection sqlConnection = null;
        public contracts()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contracts_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void contracts_Load(object sender, EventArgs e)
        {
            loadContracts();
            loadContractsOwner();
            SqlCommand command1 = new SqlCommand("SELECT u.secondName,u.firstName,u.fatherName from users as u", sqlConnection);
            SqlDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                buyer.Items.Add(Convert.ToString(reader["secondName"]) + ' ' + Convert.ToString(reader["firstName"]) + ' ' + Convert.ToString(reader["fatherName"]));
                owner.Items.Add(Convert.ToString(reader["secondName"]) + ' ' + Convert.ToString(reader["firstName"]) + ' ' + Convert.ToString(reader["fatherName"]));
            }
            reader.Close();

            SqlCommand command2 = new SqlCommand("SELECT o.Id from objects as o where o.status = N'Активно'", sqlConnection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                apartamentBuyer.Items.Add(Convert.ToString(reader2["Id"]));
            }
            reader2.Close();

            SqlCommand command3 = new SqlCommand("select o.Id from objects as o where o.status = N'Активно'", sqlConnection);
            SqlDataReader reader3 = command3.ExecuteReader();
            while(reader3.Read())
            {
                apartamentOwner.Items.Add(Convert.ToString(reader3["Id"]));
            }
            reader3.Close();

            SqlCommand command4 = new SqlCommand("select a.secondName,a.firstName,a.fatherName from admins as a", sqlConnection);
            SqlDataReader reader4 = command4.ExecuteReader();
            while (reader4.Read())
            {
                realtorBuyer.Items.Add(Convert.ToString(reader4["secondName"]) + ' ' + Convert.ToString(reader4["firstName"]) + ' ' + Convert.ToString(reader4["fatherName"]));
                realtorOwner.Items.Add(Convert.ToString(reader4["secondName"]) + ' ' + Convert.ToString(reader4["firstName"]) + ' ' + Convert.ToString(reader4["fatherName"]));
            }
            reader4.Close();
            statusBayer.Items.Add("Подписан");
            statusBayer.Items.Add("Не подписан");
            statusOwner.Items.Add("Подписан");
            statusOwner.Items.Add("Не подписан");
        }

        private void loadContracts()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT c.Id as N'№',(select secondName+' '+firstName+' '+fatherName from users where Id = c.owner) as N'ФИО Владельца', (select secondName+' '+firstName+' '+fatherName from users where Id = c.buyer) as N'ФИО Покупателя', c.Apartament as N'Номер Недвижимости',  a.secondName+' '+a.firstName+' '+a.fatherName as N'ФИО Риэлтора', c.price as N'Цена контракта', c.status as N'Статус контракта' FROM contracts as c, admins as a where c.realtor = a.Id", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void loadContractsOwner()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT c.Id as N'№',(select secondName+' '+firstName+' '+fatherName from users where Id = c.owner) as N'ФИО Владельца', c.Apartament as N'Номер Недвижимости',  a.secondName+' '+a.firstName+' '+a.fatherName as N'ФИО Риэлтора', c.price as N'Цена контракта', c.status as N'Статус контракта' FROM contractsOwner as c, admins as a where c.realtor = a.Id", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    int contractID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                    buyer.SelectedItem = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value);
                    apartamentBuyer.SelectedItem = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value);
                    realtorBuyer.SelectedItem = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value);
                    priceBuyer.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value);
                    statusBayer.SelectedItem = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[6].Value);

                }
                else
                {
                    MessageBox.Show("Вы не выбрали контракт");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали контракт");
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    int contractID = Convert.ToInt32(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[0].Value);
                    owner.SelectedItem = Convert.ToString(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[1].Value);
                    apartamentOwner.SelectedItem = Convert.ToString(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[2].Value);
                    realtorOwner.SelectedItem = Convert.ToString(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[3].Value);
                    priceOwner.Text = Convert.ToString(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[4].Value);
                    statusOwner.SelectedItem = Convert.ToString(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[5].Value);
                }
                else
                {
                    MessageBox.Show("Вы не выбрали контракт");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали контракт");
            }
        }

        public bool isNotClearContracts()
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(buyer.SelectedItem)) | string.IsNullOrWhiteSpace(Convert.ToString(apartamentBuyer.SelectedItem)) | string.IsNullOrWhiteSpace(Convert.ToString(realtorBuyer.SelectedItem)) | string.IsNullOrWhiteSpace(Convert.ToString(priceBuyer.Text)) | string.IsNullOrWhiteSpace(Convert.ToString(statusBayer.SelectedItem)))
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNotClearContracts())
            {
                SqlCommand command2 = new SqlCommand("SELECT* from objects as o,contracts as c where o.Id = '"+ Convert.ToString(apartamentBuyer.SelectedItem) + "' and c.apartament = o.id", sqlConnection);
                SqlDataReader reader2 = command2.ExecuteReader();
                if(reader2.Read())
                {
                    MessageBox.Show("Контракт на данную недвижимость уже подписан!");
                    reader2.Close();
                    return;
                }
                reader2.Close();

                string idOwner = "";
                SqlCommand command3 = new SqlCommand("SELECT idUser from objects as o where o.Id = '" + Convert.ToString(apartamentBuyer.SelectedItem) + "'", sqlConnection);
                SqlDataReader reader3 = command3.ExecuteReader();
                if (reader3.Read())
                {
                    idOwner = Convert.ToString(reader3["idUser"]);
                }
                reader3.Close();


                SqlCommand command = new SqlCommand("INSERT INTO contracts (owner, buyer, apartament, realtor, price, status) VALUES (@owner,@buyer,@apartament,@realtor,@price,@status)", sqlConnection);
                command.Parameters.AddWithValue("owner", idOwner);
                command.Parameters.AddWithValue("buyer", searchUser(Convert.ToString(buyer.SelectedItem)));
                command.Parameters.AddWithValue("apartament", Convert.ToString(apartamentBuyer.SelectedItem));
                command.Parameters.AddWithValue("realtor", searchRealtor(Convert.ToString(realtorBuyer.SelectedItem)));
                command.Parameters.AddWithValue("price", Convert.ToString(priceBuyer.Text));
                command.Parameters.AddWithValue("status", Convert.ToString(statusBayer.SelectedItem));
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Контракт добавлен!");
                }
                else
                {
                    MessageBox.Show("Контракт не добавлен!");
                }
                loadContracts();
            }
            else
            {
                MessageBox.Show("Вы вводите пустые значения");
            }
        }

        public bool isNotClearContractsOwner()
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(owner.SelectedItem)) | string.IsNullOrWhiteSpace(Convert.ToString(apartamentOwner.SelectedItem)) | string.IsNullOrWhiteSpace(Convert.ToString(realtorOwner.SelectedItem)) | string.IsNullOrWhiteSpace(Convert.ToString(priceOwner.Text)) | string.IsNullOrWhiteSpace(Convert.ToString(statusOwner.SelectedItem)))
            {
                return false;
            }
            return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isNotClearContractsOwner())
            {
                SqlCommand command2 = new SqlCommand("SELECT* from objects as o,contractsOwner as c where o.Id = '" + Convert.ToString(apartamentOwner.SelectedItem) + "' and c.apartament = o.id", sqlConnection);
                SqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.Read())
                {
                    MessageBox.Show("Контракт на данную недвижимость уже подписан!");
                    reader2.Close();
                    return;
                }
                reader2.Close();


                SqlCommand command = new SqlCommand("INSERT INTO contractsOwner (owner, apartament, realtor, price, status) VALUES (@owner,@apartament,@realtor,@price,@status)", sqlConnection);
                command.Parameters.AddWithValue("owner", searchUser(Convert.ToString(owner.SelectedItem)));
                command.Parameters.AddWithValue("apartament", Convert.ToString(apartamentOwner.SelectedItem));
                command.Parameters.AddWithValue("realtor", searchRealtor(Convert.ToString(realtorOwner.SelectedItem)));
                command.Parameters.AddWithValue("price", Convert.ToString(priceOwner.Text));
                command.Parameters.AddWithValue("status", Convert.ToString(statusOwner.SelectedItem));
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Контракт добавлен!");
                }
                else
                {
                    MessageBox.Show("Контракт не добавлен!");
                }
                loadContractsOwner();
            }
            else
            {
                MessageBox.Show("Вы вводите пустые значения");
            }
        }

        private string searchUser(string name) // Найти ИД пользователя
        {
            string[] data = name.Split(' ');
            string idUser = "";

            SqlCommand command1 = new SqlCommand("SELECT u.id from users as u where u.secondName=N'" + data[0] +"' and u.firstName=N'" + data[1] +"' and u.fatherName=N'" + data[2] +"'", sqlConnection);
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                idUser = Convert.ToString(reader["id"]);
                reader.Close();
            }
            reader.Close();
            return idUser;
        }

        private string searchRealtor(string name) // Найти ИД пользователя
        {
            string[] data = name.Split(' ');
            string idUser = "";

            SqlCommand command1 = new SqlCommand("SELECT u.id from admins as u where u.secondName=N'" + data[0] + "' and u.firstName=N'" + data[1] + "' and u.fatherName=N'" + data[2] + "'", sqlConnection);
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                idUser = Convert.ToString(reader["id"]);
                reader.Close();
            }
            reader.Close();
            return idUser;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string idOwner = "";
            SqlCommand command3 = new SqlCommand("SELECT idUser from objects as o where o.Id = '" + Convert.ToString(apartamentBuyer.SelectedItem) + "'", sqlConnection);
            SqlDataReader reader3 = command3.ExecuteReader();
            if (reader3.Read())
            {
                idOwner = Convert.ToString(reader3["idUser"]);
            }
            reader3.Close();


            int contractId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("update contracts Set owner = @owner, buyer = @buyer, apartament = @apartament, realtor = @realtor, price = @price, status = @status where id = @contractId", sqlConnection);
            command.Parameters.AddWithValue("owner", idOwner);
            command.Parameters.AddWithValue("buyer", searchUser(Convert.ToString(buyer.SelectedItem)));
            command.Parameters.AddWithValue("apartament", Convert.ToString(apartamentBuyer.SelectedItem));
            command.Parameters.AddWithValue("realtor", searchRealtor(Convert.ToString(realtorBuyer.SelectedItem)));
            command.Parameters.AddWithValue("price", Convert.ToString(priceBuyer.Text));
            command.Parameters.AddWithValue("status", Convert.ToString(statusBayer.SelectedItem));
            command.Parameters.AddWithValue("contractId", contractId);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Контракт редактирован!");
            }
            else
            {
                MessageBox.Show("Контракт не редактирован!");
            }
            loadContracts();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int contractId = Convert.ToInt32(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("update contractsOwner Set owner = @owner, apartament = @apartament, realtor = @realtor, price = @price, status = @status where id = @contractId", sqlConnection);
            command.Parameters.AddWithValue("owner", searchUser(Convert.ToString(owner.SelectedItem)));
            command.Parameters.AddWithValue("apartament", Convert.ToString(apartamentOwner.SelectedItem));
            command.Parameters.AddWithValue("realtor", searchRealtor(Convert.ToString(realtorOwner.SelectedItem)));
            command.Parameters.AddWithValue("price", Convert.ToString(priceOwner.Text));
            command.Parameters.AddWithValue("status", Convert.ToString(statusOwner.SelectedItem));
            command.Parameters.AddWithValue("contractId", contractId);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Контракт редактирован!");
            }
            else
            {
                MessageBox.Show("Контракт не редактирован!");
            }
            loadContractsOwner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int contractId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("delete contracts where id = @contractId", sqlConnection);
            command.Parameters.AddWithValue("contractId", contractId);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Контракт удален!");
            }
            else
            {
                MessageBox.Show("Контракт не удален!");
            }
            loadContracts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int contractId = Convert.ToInt32(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("delete contractsOwner where id = @contractId", sqlConnection);
            command.Parameters.AddWithValue("contractId", contractId);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Контракт удален!");
            }
            else
            {
                MessageBox.Show("Контракт не удален!");
            }
            loadContractsOwner();
        }
    }
}
