using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ado_userDetailForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataReader jp = EmployeeDetails.GetCity();
            while(jp.Read())
            {
                comboBox1.Items.Add(jp["cityname"].ToString());
            }

        }
    }
}
