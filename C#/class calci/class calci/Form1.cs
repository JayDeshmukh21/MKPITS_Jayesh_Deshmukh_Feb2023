using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static class_calci.Calculator;

namespace class_calci
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
        double num;

        calculator calc = new calculator();

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

        
       

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 7;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 8;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 9;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
                num = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%" || textBox1.Text == "^")
            {
                textBox1.Text = " ";
                if (textBox1.Text == " ")
                {
                    textBox1.Text = textBox1.Text + 0;
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + 0;
                num = Convert.ToInt32(textBox1.Text);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(calc.Plus_Click(Convert.ToInt32(textBox1.Text)));
            //textBox1.Text = calc.Plus_Click(num).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(calc.Minus_Click(Convert.ToInt32(textBox1.Text)));
        }


        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(calc.Multiply_Click(Convert.ToInt32(textBox1.Text)));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(calc.Divide_Click(Convert.ToInt32(textBox1.Text)));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double result = calc.calculateResult(Convert.ToSingle(textBox1.Text));
            textBox1.Text = result.ToString();
            num = result;
        }



        private void button12_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
        }
    }
}
