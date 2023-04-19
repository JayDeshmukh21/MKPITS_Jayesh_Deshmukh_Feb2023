using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assisgnment_2
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        int[,] arr;
        int row, col;
        int i = 0;
        int j = 0;

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (i < row)
            {
                if (j < col)
                {
                    arr[i, j] = Convert.ToInt32(textBox3.Text);
                    textBox3.Clear();
                    textBox3.Clear();
                    textBox3.Focus();
                    j = j + 1;
                }
                if (j == col)
                {
                    i = i + 1;
                    j = 0;
                }
                if (i == row)
                {
                    button2.Enabled = false;
                    button3.Enabled = true;

                }

            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    sb.Append(arr[i, j] + "  ");
                }
                sb.Append("\n");
            }
            label4.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            row = Convert.ToInt32(textBox1.Text);
            col = Convert.ToInt32(textBox2.Text);
            arr = new int[row, col];
            button1.Enabled = false;

        }


    }
}
