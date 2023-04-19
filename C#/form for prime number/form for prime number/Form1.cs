using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_for_prime_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(textBox1.Text);
            int count = 0;
            int isprime = 0;
            for (count = 2; count < n; count++)
            {
                if (n % count == 0)
                {
                    isprime = 1;
                    break;
                }
            }
            if (isprime == 0) 
            {
                label2.Text =n + " is prime no" ;
            }
            else
            {
                label2.Text = n + "  is not a prime no ";
            }
        }
    }
}
