using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado_userDetailForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text=DatabaseConnection.InsertRecord(textBox1.Text, textBox2.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text= DatabaseConnection.UpdateRecord(textBox1.Text, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = DatabaseConnection.DeleteRecord(textBox1.Text);
            
        }
    }
}
