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

namespace RealtorAgency
{
    public partial class Request : Form
    {
        public MainForm form1 = new MainForm();
        private SqlConnection sqlConnection = null;
        public Request()
        {
            InitializeComponent();

            BaseEdit sql = new BaseEdit();
            sqlConnection = sql.sqlConnection;

            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение не установлено.");
                return;
            }
            comboRequest.Items.Insert(0, "Вывести объекты с типом недвижимости");
            comboRequest.Items.Insert(1, "Вывести объекты с площадью >");
            comboRequest.Items.Insert(2, "Вывести объекты с площадью <");
            comboRequest.Items.Insert(3, "Вывести подписанные договоры с покупателем");
            comboRequest.Items.Insert(4, "Вывести подписанные договоры с владельцем");
            comboRequest.Items.Insert(5, "Вывести объекты, добавленные меньше даты 'годмесяцдень'");
            comboRequest.Items.Insert(6, "Вывести пользователя с фамилией");
            comboRequest.Items.Insert(7, "Вывести объекты c ценой >");
            comboRequest.Items.Insert(8, "Вывести объекты c ценой <");
            comboRequest.Items.Insert(9, "Вывести риэлторов с фамилией");
        }

        private void Request_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = "";
            if (comboRequest.Text == "Вывести объекты с типом недвижимости")
            {
                if (textBox1.Text != "")
                {
                    string type = "";
                    int typeID;
                    SqlCommand command1 = new SqlCommand("SELECT* from type where name=N'" + textBox1.Text + "'", sqlConnection);
                    SqlDataReader reader = command1.ExecuteReader();
                    if (reader.Read())
                    {
                        type = Convert.ToString(reader["Id"]);
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Не найден тип недвижимости");
                        reader.Close();
                        return;
                    }
                    Text = "Select o.id as N'№', o.edited as N'Дата', o.description as N'Описание', o.price as N'Цена', t.name as N'Тип недвижимости', o.address as N'Адрес', o.status as N'Статус', o.square as N'Площадь', o.square_land as N'Площадь земельного участка', o.rooms as N'Количество комнат', o.floor as N'Этаж', u.secondName+' '+u.firstName+' '+u.fatherName as N'ФИО владельца' from objects as o, type as t, users as u where o.type = " + type + " and t.id = " + type + " and o.idUser = u.Id";
                }
                else
                {
                    MessageBox.Show("Вы ничего не ввели в поле 'Значение'");
                    return;
                }
            }
            else if (comboRequest.Text == "Вывести объекты с площадью >")
            {
                if (textBox1.Text != "")
                {
                    string square = textBox1.Text;
                    if (square == "")
                    {
                        MessageBox.Show("Вы неправильно ввели значение.");
                        return;
                    }
                    try
                    {
                        int squareInt = Convert.ToInt32(square);
                        if (squareInt <= 0)
                        {
                            MessageBox.Show("Вы ввели отрицательное значение, либо не численное значение");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Вы ввели отрицательное значение, либо не численное значение");
                        return;
                    }
                    Text = "Select o.id as N'№', o.edited as N'Дата создания', o.description as N'Описание', o.price as N'Цена', t.name as N'Тип недвижимости', o.address as N'Адрес', o.status as N'Статус', o.square as N'Площадь', o.square_land as N'Общая площадь', o.rooms as N'Комнаты', o.floor as N'Этаж', u.secondName+' '+u.firstName+' '+u.fatherName as N'ФИО владельца' from objects as o, type as t, users as u where o.square > " + square + " and o.type = t.id and o.idUser = u.Id";
                }
                else
                {
                    MessageBox.Show("Вы ничего не ввели в поле 'Значение'");
                    return;
                }
            }
            else if (comboRequest.Text == "Вывести объекты с площадью <")
            {
                if (textBox1.Text != "")
                {
                    string square = textBox1.Text;
                    try
                    {
                        int squareInt = Convert.ToInt32(square);
                        if (squareInt <= 0)
                        {
                            MessageBox.Show("Вы ввели отрицательное значение, либо не численное значение");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Вы ввели отрицательное значение, либо не численное значение");
                        return;
                    }
                    Text = "Select o.id as N'№', o.edited as N'Дата создания', o.description as N'Описание', o.price as N'Цена', t.name as N'Тип недвижимости', o.address as N'Адрес', o.status as N'Статус', o.square as N'Площадь', o.square_land as N'Общая площадь', o.rooms as N'Комнаты', o.floor as N'Этаж', u.secondName+' '+u.firstName+' '+u.fatherName as N'ФИО владельца' from objects as o, type as t, users as u where o.square < " + square + " and o.type = t.id and o.idUser = u.Id";
                }
                else
                {
                    MessageBox.Show("Вы ничего не ввели в поле 'Значение'");
                    return;
                }
            }
            else if (comboRequest.Text == "Вывести подписанные договоры с владельцем")
            {
                if (textBox1.Text != "")
                {
                    string fio = textBox1.Text;
                    Text = "SELECT c.Id as N'№',(select secondName+' '+firstName+' '+fatherName from users where Id = c.owner) as N'ФИО Владельца', c.Apartament as N'Номер Недвижимости',  a.secondName+' '+a.firstName+' '+a.fatherName as N'ФИО Риэлтора', c.price as N'Цена контракта', c.status as N'Статус контракта' FROM contractsOwner as c, admins as a, users as u where c.realtor = a.Id and u.secondName = N'" + fio + "' and c.owner = u.Id";
                }
                else
                {
                    MessageBox.Show("Вы ничего не ввели в поле 'Значение'");
                    return;
                }
            }
            else if (comboRequest.Text == "Вывести подписанные договоры с покупателем")
            {
                if (textBox1.Text != "")
                {
                    string fio = textBox1.Text;
                    Text = "SELECT DISTINCT c.Id as N'№',(select secondName+' '+firstName+' '+fatherName from users where Id = c.owner) as N'ФИО Владельца', (select secondName+' '+firstName+' '+fatherName from users where Id = c.buyer) as N'ФИО Покупателя', c.Apartament as N'Номер Недвижимости',  a.secondName+' '+a.firstName+' '+a.fatherName as N'ФИО Риэлтора', c.price as N'Цена контракта', c.status as N'Статус контракта' FROM contracts as c, admins as a, users as u where c.realtor = a.Id and u.secondName = N'" + fio + "'";
                }
                else
                {
                    MessageBox.Show("Вы ничего не ввели в поле 'Значение'");
                    return;
                }
            }
            else if (comboRequest.Text == "Вывести объекты, добавленные меньше даты 'годмесяцдень'")
            {
                if (textBox1.Text != "")
                {
                    string data = textBox1.Text;
                    try
                    {
                        int dataInt = Convert.ToInt32(data);
                        if (dataInt <= 0)
                        {
                            MessageBox.Show("Вы ввели отрицательное значение, либо не численное значение");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Вы ввели отрицательное значение, либо не численное значение");
                        return;
                    }
                    Text = "Select o.id as N'№', o.edited as N'Дата создания', o.description as N'Описание', o.price as N'Цена', t.name as N'Тип недвижимости', o.address as N'Адрес', o.status as N'Статус', o.square as N'Площадь', o.square_land as N'Общая площадь', o.rooms as N'Комнаты', o.floor as N'Этаж', u.secondName+' '+u.firstName+' '+u.fatherName as N'ФИО владельца' from objects as o, type as t, users as u where o.edited <= '" + data + "' and o.type = t.id and o.idUser = u.Id";
                }
                else
                {
                    MessageBox.Show("Вы ничего не ввели в поле 'Значение'");
                    return;
                }
            }
            else if (comboRequest.Text == "Вывести пользователя с фамилией")
            {
                if (textBox1.Text != "")
                {
                    string fio = textBox1.Text;
                    Text = "Select u.secondName+' '+u.firstName+' '+u.fatherName as N'ФИО', u.number as N'Номер телефона', u.email as N'Почта', u.passport as N'Паспорт' from users as u where u.secondName = N'"+fio+"'";
                }
                else if (comboRequest.Text == "")
                {
                    MessageBox.Show("Вы не выбрали запрос");
                    return;
                }
            }
            else if (comboRequest.Text == "Вывести объекты c ценой >")
            {
                if (textBox1.Text != "")
                {
                    string price = textBox1.Text;
                    if (price == "")
                    {
                        MessageBox.Show("Вы неправильно ввели значение.");
                        return;
                    }
                    try
                    {
                        int priceInt = Convert.ToInt32(price);
                        if (priceInt <= 0)
                        {
                            MessageBox.Show("Вы ввели отрицательное значение, либо не численное значение");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Вы ввели отрицательное значение, либо не численное значение");
                        return;
                    }
                    Text = "Select o.id as N'№', o.edited as N'Дата создания', o.description as N'Описание', o.price as N'Цена', t.name as N'Тип недвижимости', o.address as N'Адрес', o.status as N'Статус', o.square as N'Площадь', o.square_land as N'Общая площадь', o.rooms as N'Комнаты', o.floor as N'Этаж', u.secondName+' '+u.firstName+' '+u.fatherName as N'ФИО владельца' from objects as o, type as t, users as u where o.price > " + price + " and o.type = t.id and o.idUser = u.Id";
                }
                else
                {
                    MessageBox.Show("Вы ничего не ввели в поле 'Значение'");
                    return;
                }
            }
            else if (comboRequest.Text == "Вывести объекты c ценой <")
            {
                if (textBox1.Text != "")
                {
                    string price = textBox1.Text;
                    if (price == "")
                    {
                        MessageBox.Show("Вы неправильно ввели значение.");
                        return;
                    }
                    try
                    {
                        int priceInt = Convert.ToInt32(price);
                        if (priceInt <= 0)
                        {
                            MessageBox.Show("Вы ввели отрицательное значение, либо не численное значение");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Вы ввели отрицательное значение, либо не численное значение");
                        return;
                    }
                    Text = "Select o.id as N'№', o.edited as N'Дата создания', o.description as N'Описание', o.price as N'Цена', t.name as N'Тип недвижимости', o.address as N'Адрес', o.status as N'Статус', o.square as N'Площадь', o.square_land as N'Общая площадь', o.rooms as N'Комнаты', o.floor as N'Этаж', u.secondName+' '+u.firstName+' '+u.fatherName as N'ФИО владельца' from objects as o, type as t, users as u where o.price < " + price + " and o.type = t.id and o.idUser = u.Id";
                }
                else
                {
                    MessageBox.Show("Вы ничего не ввели в поле 'Значение'");
                    return;
                }
            }
            else if (comboRequest.Text == "Вывести риэлторов с фамилией")
            {
                if (textBox1.Text != "")
                {
                    string fio = textBox1.Text;
                    Text = "Select a.id as N'№', a.login as N'Логин', a.password as N'Пароль',a.secondName+' '+a.firstName+' '+a.fatherName as N'ФИО Риэлтора',a.number as N'Номер Телефона',a.email as N'Почта' from admins as a where a.secondName = N'"+fio+"'";
                }
                else
                {
                    MessageBox.Show("Вы ничего не ввели в поле 'Значение'");
                    return;
                }
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Text, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            requsts.DataSource = dataSet.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRequest.SelectedIndex == 0)
            {
                textBox1.Text = "Коттедж/Квартира";
            }
            if (comboRequest.SelectedIndex == 1)
            {
                textBox1.Text = "100/200";
            }
            if (comboRequest.SelectedIndex == 2)
            {
                textBox1.Text = "100/200";
            }
            if (comboRequest.SelectedIndex == 3)
            {
                textBox1.Text = "Фамилия";
            }
            if (comboRequest.SelectedIndex == 4)
            {
                textBox1.Text = "Фамилия";
            }
            if (comboRequest.SelectedIndex == 5)
            {
                textBox1.Text = "20230101";
            }
            if (comboRequest.SelectedIndex == 6)
            {
                textBox1.Text = "Ишалин";
            }
            if (comboRequest.SelectedIndex == 7)
            {
                textBox1.Text = "1000000";
            }
            if (comboRequest.SelectedIndex == 8)
            {
                textBox1.Text = "1000000";
            }
            if (comboRequest.SelectedIndex == 9)
            {
                textBox1.Text = "Фамилия";
            }
        }
    }
}
