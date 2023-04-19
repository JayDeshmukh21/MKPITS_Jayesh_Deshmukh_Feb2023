using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assisgnment_1
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int[] arr = new int[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < arr.Length)
            {
                arr[counter] = Convert.ToInt32(textBox1.Text);
                counter++;
            }

            else if (counter == arr.Length)
            {
                button1.Enabled = false;
            }

            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                label2.Text += " " + arr[i];
            }
            button2.Enabled = false;
        }
    }
}

