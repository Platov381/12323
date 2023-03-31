using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RealtorAgency
{
    public partial class objects : Form
    {
        public MainForm form1 = new MainForm();
        private SqlConnection sqlConnection = null;
        public objects()
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

        private void objects_Load(object sender, EventArgs e)
        {
            loadData();
            SqlCommand command1 = new SqlCommand("SELECT* from type", sqlConnection);
            SqlDataReader reader = command1.ExecuteReader();
            while(reader.Read())
            {
                type.Items.Add(Convert.ToString(reader["name"]));
            }
            reader.Close();
            SqlCommand command2 = new SqlCommand("SELECT * from users", sqlConnection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                string nameUser = Convert.ToString(reader2["secondName"]) + " " + Convert.ToString(reader2["firstName"]) + " " + Convert.ToString(reader2["fatherName"]);
                fio.Items.Add(nameUser);
            }
            reader2.Close();
            status.Items.Add("Активно");
            status.Items.Add("Не активно");
        }

        private void objects_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void loadData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT o.Id as N'№', o.edited as N'Дата изменения', o.description as N'Описание недвижимости',o.price as N'Цена', t.name as N'Тип недвижимости', o.address as N'Адрес', o.status as N'Статус', o.square as N'Площадь недвижимости', o.square_land as N'Площадь земельного участка', o.floor as N'Этаж', o.rooms as N'Количество комнат', u.secondName as N'Фамилия владельца', u.firstName as N'Имя владельца', u.fatherName as N'Отчетство владельца'    FROM objects o, users u, type as t where o.idUser = u.Id and o.type = t.Id", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        public bool isNotClear()
        {
            if (string.IsNullOrWhiteSpace(price.Text) | string.IsNullOrWhiteSpace(square.Text) | string.IsNullOrWhiteSpace(square_land.Text) | string.IsNullOrWhiteSpace(rooms.Text) | string.IsNullOrWhiteSpace(Convert.ToString(type.SelectedItem)) | string.IsNullOrWhiteSpace(address.Text) | string.IsNullOrWhiteSpace(floor.Text) | string.IsNullOrWhiteSpace(Convert.ToString(status.SelectedItem)) | string.IsNullOrWhiteSpace(Convert.ToString(fio.SelectedItem)) | string.IsNullOrWhiteSpace(description.Text))
            {
                return false;
            }
            return true;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    int objectID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                    price.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value);
                    square.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[7].Value);
                    square_land.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[8].Value);
                    rooms.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[10].Value);
                    type.SelectedItem = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value);
                    address.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value);
                    floor.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[9].Value);
                    status.SelectedItem = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[6].Value);
                    description.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value);
                    string fioText = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[11].Value) + " " +
                        Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[12].Value) + " " +
                        Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[13].Value);
                    fio.SelectedItem = fioText;

                }
                else
                {
                    MessageBox.Show("Вы не выбрали недвижимость");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали недвижимость");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int objectID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);

            int typeID;
            SqlCommand command1 = new SqlCommand("SELECT* from type where name=N'" + Convert.ToString(type.SelectedItem) + "'", sqlConnection);
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                typeID = Convert.ToInt32(reader["Id"]);
            }
            else
            {
                MessageBox.Show("Не выбран/найден тип недвижимости");
                typeID = 0;
                return;
            }
            reader.Close();


            int userID;
            string fioText = Convert.ToString(fio.SelectedItem);
            string[] fioTexts = fioText.Split(' ');
            SqlCommand command2 = new SqlCommand("SELECT* from users where firstName=N'" + fioTexts[1] + "' and secondName=N'" + fioTexts[0] + "' and fatherName=N'" + fioTexts[2] + "'", sqlConnection);
            SqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                userID = Convert.ToInt32(reader2["Id"]);
            }
            else
            {
                MessageBox.Show("Не выбран/найден клиент");
                userID = 0;
                return;
            }
            reader2.Close();

            DateTime thisDay = DateTime.Today;

            SqlCommand command = new SqlCommand("update objects set edited = @edited, description = @description, price = @price, type = @type, address = @address, status = @status, square = @square, square_land = @square_land, rooms = @rooms, idUser = @userID, floor = @floor  where Id = @objectID", sqlConnection);
            command.Parameters.AddWithValue("objectID", objectID);
            command.Parameters.AddWithValue("edited", thisDay);
            command.Parameters.AddWithValue("description", description.Text);
            command.Parameters.AddWithValue("price", price.Text);
            command.Parameters.AddWithValue("type", typeID);
            command.Parameters.AddWithValue("address", address.Text);
            command.Parameters.AddWithValue("status", Convert.ToString(status.SelectedItem));
            command.Parameters.AddWithValue("square", square.Text);
            command.Parameters.AddWithValue("square_land", square_land.Text);
            command.Parameters.AddWithValue("rooms", rooms.Text);
            command.Parameters.AddWithValue("floor", floor.Text);
            command.Parameters.AddWithValue("userID", userID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные о Недвижимости изменены!");
            }
            else
            {
                MessageBox.Show("Данные о Недвижимости не изменены!");
            }
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int typeID = 0;
            SqlCommand command1 = new SqlCommand("SELECT* from type where name=N'"+ Convert.ToString(type.SelectedItem)+"'", sqlConnection);
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                typeID = Convert.ToInt32(reader["Id"]);
            }
            else
            {
                MessageBox.Show("Не выбран/найден тип недвижимости");
                reader.Close();
                return;
            }
            reader.Close();

            int userID;
            string fioText = Convert.ToString(fio.SelectedItem);
            string[] fioTexts = fioText.Split(' ');
            SqlCommand command2 = new SqlCommand("SELECT* from users where firstName=N'"+ fioTexts[1] + "' and secondName=N'"+ fioTexts[0] + "' and fatherName=N'"+ fioTexts[2] + "'", sqlConnection);
            SqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                userID = Convert.ToInt32(reader2["Id"]);
            }
            else
            {
                MessageBox.Show("Не выбран/найден клиент");
                userID = 0;
                return;
            }
            reader2.Close();
           

            DateTime thisDay = DateTime.Today;

            SqlCommand command = new SqlCommand("INSERT INTO objects (edited, description, price, type, address, status, square, square_land, rooms, idUser, floor) VALUES (@edited, @description, @price, @type, @address, @status, @square, @square_land, @rooms, @userID, @floor)", sqlConnection);
            command.Parameters.AddWithValue("edited", thisDay);
            command.Parameters.AddWithValue("description", description.Text);
            command.Parameters.AddWithValue("price", price.Text);
            command.Parameters.AddWithValue("type", typeID);
            command.Parameters.AddWithValue("address", address.Text);
            command.Parameters.AddWithValue("status", Convert.ToString(status.SelectedItem));
            command.Parameters.AddWithValue("square", square.Text);
            command.Parameters.AddWithValue("square_land", square_land.Text);
            command.Parameters.AddWithValue("rooms", rooms.Text);
            command.Parameters.AddWithValue("floor", floor.Text);
            command.Parameters.AddWithValue("userID", userID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Недвижимость добавлена!");
            }
            else
            {
                MessageBox.Show("Недвижимость не добавлена!");
            }
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int objectID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("delete objects where id = @objectID", sqlConnection);
            command.Parameters.AddWithValue("objectID", objectID);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Недвижимость удалена!");
                }
                else
                {
                    MessageBox.Show("Недвижимость не удалена!");
                }
                loadData();
            }
            catch
            {
                MessageBox.Show("Ошибка, удалите все связи с данной недвижимостью.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    int objectID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                    this.Hide();
                    photosObjects photosObjectsForm = new photosObjects(objectID);
                    photosObjectsForm.Show();
                }
                else
                {
                    MessageBox.Show("Вы не выбрали недвижимость");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали недвижимость");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
