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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "1";
        }
        calculator cal = new calculator();
        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(cal.plusclick(Convert.ToInt32(textBox3.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int result = cal.calculateresult(Convert.ToInt32(textBox3.Text));
            textBox3.Text = result.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(cal.minusclick(Convert.ToInt32(textBox3.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "3";
        }
    }
}
