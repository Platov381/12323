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
using Microsoft.Win32;
using System.IO;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlTypes;
using System.Threading;
using System.Windows.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RealtorAgency
{
    public partial class photosObjects : Form
    {
        public MainForm form1 = new MainForm();
        private SqlConnection sqlConnection = null;
        private object dispatcher;
        private byte[] imgByte;
        private int idObject = 0;
        public photosObjects(int idObject = 0)
        {
            InitializeComponent();

            BaseEdit sql = new BaseEdit();
            sqlConnection = sql.sqlConnection;

            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение не установлено.");
                return;
            }

            if (idObject != 0) this.idObject = idObject;
        }

        private void photosObjects_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void photosObjects_Load(object sender, EventArgs e)
        {
            loadData();
            SqlCommand command1 = new SqlCommand("SELECT Id from objects", sqlConnection);
            SqlDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                objects.Items.Add(Convert.ToString(reader["Id"]));
            }
            reader.Close();
            // load();
        }

        private void loadData()
        {
            string textsql = "SELECT Id as N'№', idObject as N'ИД Объекта', path as N'Фотография', altName as N'Название фотографии' FROM images";
            if (this.idObject > 0) textsql = "SELECT Id as N'№', idObject as N'ИД Объекта', path as N'Фотография', altName as N'Название фотографии' FROM images where idObject = "+idObject;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(textsql, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private void SelectImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // создаем диалоговое окно
            openFileDialog.ShowDialog(); // показываем
            byte[] image_bytes = File.ReadAllBytes(openFileDialog.FileName); // получаем байты выбранного файла
            SqlCommand command = new SqlCommand(); // создадим запрос
            command.Connection = sqlConnection; // дадим запросу подключение
            command.CommandText = @"INSERT INTO images (path, idObject)VALUES (@ImageData, 1)"; // пропишем запрос
            command.Parameters.Add("@ImageData", SqlDbType.Image, 1000000);
            command.Parameters["@ImageData"].Value = image_bytes;// скалярной переменной ImageData присвоем массив байтов
            command.ExecuteNonQuery(); // запустим
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Фотография загружена");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Изображения формата(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            System.Drawing.Image image1 = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            Image.Image = image1;
            ImageConverter imgCon = new ImageConverter();
            imgByte = (byte[])imgCon.ConvertTo(image1, typeof(byte[]));
        }

        public bool isNotClear()
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(objects.SelectedItem)) | string.IsNullOrWhiteSpace(name.Text) | Image.Image == null)
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNotClear())
            {
                SqlCommand command = new SqlCommand("INSERT INTO images (idObject, path, altName) VALUES (@idObject, @path, @name)", sqlConnection);
                command.Parameters.AddWithValue("idObject", Convert.ToString(objects.SelectedItem));
                command.Parameters.AddWithValue("path", imgByte);
                command.Parameters.AddWithValue("name", name.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Картинка добавлена");
                }
                else
                {
                    MessageBox.Show("Картинка не добавлена");
                }
                loadData();
            }
            else
            {
                MessageBox.Show("Вы что-то не ввели или не добавили картинку.");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    objects.SelectedItem = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value);
                    name.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value);
                    System.Drawing.Image image = null;
                    using (MemoryStream mStream = new MemoryStream((byte[])dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value))
                    {
                        image = System.Drawing.Image.FromStream(mStream);
                    }
                    Image.Image = image;
                }
                else
                {
                    MessageBox.Show("Вы не выбрали фотографию");
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали фотографию");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int photoId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("update images Set idObject = @idObject, path = @path, altName = @name where id = @photoId", sqlConnection);
            command.Parameters.AddWithValue("idObject", Convert.ToInt32(objects.SelectedItem));
            command.Parameters.AddWithValue("path", imgByte);
            command.Parameters.AddWithValue("name", name.Text);
            command.Parameters.AddWithValue("photoId", photoId);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные о фотографии изменены");
            }
            else
            {
                MessageBox.Show("Данные о фотографии не изменены!");
            }
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int photoID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("delete images where id = @photoID", sqlConnection);
            command.Parameters.AddWithValue("photoID", photoID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Фото удалено!");
            }
            else
            {
                MessageBox.Show("Фото не удалено!");
            }
            loadData();
        }
    }
}
