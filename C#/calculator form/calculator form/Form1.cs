using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_form
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        int num1;
        int num2;
       
        string option;
        int result;

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn0.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = Convert.ToInt32(textBox1.Text);
            
            textBox1.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = Convert.ToInt32(textBox1.Text);

            textBox1.Clear();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = Convert.ToInt32(textBox1.Text);

            textBox1.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = Convert.ToInt32(textBox1.Text);

            textBox1.Clear();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            option = "%";
            num1 = Convert.ToInt32(textBox1.Text);

            textBox1.Clear();

        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(textBox1.Text);
            if (option.Equals("+"))
            {
                result = num1 + num2;
            }

            else if (option.Equals("-"))
            {
                result = num1 - num2;
            }

            else if (option.Equals("*"))
            {
                result = num1 * num2;
            }

            else if (option.Equals("/"))
            {
                result = num1 / num2;
            }

            else if (option.Equals("%"))
            {
                result = num1 % num2;
            }

           
                textBox1.Text = result + "";
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        
    }
}
