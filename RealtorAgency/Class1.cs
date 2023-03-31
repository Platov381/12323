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
    class DataEdit
    {
        public object data = null;

        public DataEdit(object dataBox)
        {
            data = dataBox;
        }

    }
}
