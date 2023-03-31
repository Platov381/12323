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

namespace RealtorAgency
{
    class BaseEdit
    {
        public SqlConnection sqlConnection = null;
        public BaseEdit()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            sqlConnection.Open();

            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение не установлено.");
            }
        }

        public SqlDataReader select(string tableName)
        {
            SqlCommand contracts = new SqlCommand("SELECT* from "+tableName, sqlConnection);

            SqlDataReader reader = contracts.ExecuteReader();

            return reader;
        }

    }
}
