using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1=Convert.ToInt32(textBox1.Text);
            int s2=Convert.ToInt32(textBox2.Text);
            int s3=Convert.ToInt32(textBox3.Text);

            int total=s1 + s2 + s3;
            textBox4.Text = ""+total;

            float per = total / 300.0f * 100.0f;
            textBox5.Text=""+ per;

            if(per >= 45 && per<60)
            {
                textBox6.Text = "pass";
            }
            else if (per>=60 && per<80)
            {
                textBox6.Text = "B grade 'first class'";
            }
            else if(per>=80 && per<=100)
            {
                textBox6.Text = "A grade 'pass with Distinction'";
            }
            else
            {
                textBox6.Text = "Regrate..!";
            }
        }
    }
}
