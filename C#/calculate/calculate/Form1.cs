using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate c = new calculate();
            int result = c.calculateresult(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToChar(comboBox1.Text));
            label3.Text = "result : " + result;

        }
    }
}
