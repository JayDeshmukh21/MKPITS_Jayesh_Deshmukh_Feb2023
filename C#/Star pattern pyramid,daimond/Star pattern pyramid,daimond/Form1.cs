using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_pattern_pyramid_daimond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            static void Main()
            {
                int n = 5;
                int i, j, space;

                // Upper half of the diamond
                for (i = 1; i <= n; i++)
                {
                    for (space = n - i; space > 0; space--)
                    {
                        label1.Text=" ";
                    }

                    for (j = 1; j <= (2 * i - 1); j++)
                    {
                        label1.Text="*";
                    }

                    Console.WriteLine();
                }

                // Lower half of the diamond
                for (i = n - 1; i >= 1; i--)
                {
                    for (space = 1; space <= n - i; space++)
                    {
                        Console.Write(" ");
                    }

                    for (j = 1; j <= (2 * i - 1); j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
