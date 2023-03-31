using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.Diagnostics;

namespace RealtorAgency
{
    public partial class MainForm : Form
    {
        private SqlConnection sqlConnection = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Closing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void user_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            users usersForm = new users();
            usersForm.Show();
        }

        private void object_button_click(object sender, EventArgs e)
        {
            this.Hide();
            objects objectsForm = new objects();
            objectsForm.Show();
        }

        private void type_button_click(object sender, EventArgs e)
        {
            this.Hide();
            typesObjects typeObjectsForm = new typesObjects();
            typeObjectsForm.Show();
        }

        private void photos_button_click(object sender, EventArgs e)
        {
            this.Hide();
            photosObjects photosObjectsForm = new photosObjects();
            photosObjectsForm.Show();
        }

        private void contracts_button_click(object sender, EventArgs e)
        {
            this.Hide();
            contracts contractsForm = new contracts();
            contractsForm.Show();
        }

        private void realtors_button_click(object sender, EventArgs e)
        {
            this.Hide();
            realtors realtorsForm = new realtors();
            realtorsForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Request requestForm = new Request();
            requestForm.Show();
        }
    }
}
