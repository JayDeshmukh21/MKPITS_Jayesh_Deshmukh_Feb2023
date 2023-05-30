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

namespace staticconnectionex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseConnection.GetConnection();
            if(con != null )
            {
                label1.Text = "connected successfully";
                con.Close();
            }
            else
            {
                label1.Text = "unable to connect";
            }
            string result = null;
            result = DatabaseConnection.InsertRecord(textBox1.Text, textBox2.Text);
            label1.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
