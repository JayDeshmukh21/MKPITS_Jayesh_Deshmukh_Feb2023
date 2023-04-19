using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace with_class_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 1;
                    num = Convert.ToInt32(textBox1.Text);
                }

                else
                {
                    textBox1.Text = textBox1.Text + 1;
                    num = Convert.ToInt32(textBox1.Text);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 2;
                    num = Convert.ToInt32(textBox1.Text);
                }
                else
                {
                    textBox1.Text = textBox1.Text + 2;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 3;
                    num = Convert.ToInt32(textBox1.Text);
                }
                else
                {
                    textBox1.Text = textBox1.Text + 3;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        calculator cal = new calculator();
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cal.plusclick(Convert.ToInt32(textBox1.Text)));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cal.minusclick(Convert.ToInt32(textBox1.Text)));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cal.multiplyclick(Convert.ToInt32(textBox1.Text)));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cal.divclick(Convert.ToInt32(textBox1.Text)));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int result = cal.calculateresult(Convert.ToInt32(textBox1.Text));
            textBox1.Text = result.ToString();
            num = result;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
        }
    }
}
