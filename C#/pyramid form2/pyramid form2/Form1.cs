using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyramid_form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int height = Convert.ToInt32(textBox1.Text);
            for (int i = height; i >= 1; i--)
            {
                for (int j = height - i; j >= 1; j--)
                {
                    sb.Append(" ");
                }
                for (int k = 2 * i - 1; k >= 1; k--)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            label2.Text = sb.ToString();
        }
    }
}
