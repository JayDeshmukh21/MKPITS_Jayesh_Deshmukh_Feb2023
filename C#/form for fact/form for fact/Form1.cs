using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_for_fact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fact = 1;
            int num = Convert.ToInt32(textBox1.Text);
            for (int i = num; i > 0; i--)
            {
                fact = fact * i;
                label2.Text = "factorial is " + fact;
            }
            
        }
    }
}
