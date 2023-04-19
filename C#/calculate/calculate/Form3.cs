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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double num;
        calculator calci = new calculator();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 1;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 2;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 3;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 4;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 5;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 5;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 6;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            //textBox1.Text = calc.Plus_Click(num).ToString();
        }
    }
}
