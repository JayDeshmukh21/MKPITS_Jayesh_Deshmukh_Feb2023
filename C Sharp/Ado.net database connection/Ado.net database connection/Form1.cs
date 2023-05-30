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


namespace Ado.net_database_connection

    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating string
            string constr = "server = .\\sqlexpress;integrated security = true; database = flipcart;";

            //connection
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                label1.Text = "connection successfull";
            }
            catch (Exception ex)
            {
                label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }

        }
    }
}
