using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_for__salary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int basicsalary, hra,da, totalsalary;
            string empname;
            empname = (textBox1.Text);
            basicsalary=Convert.ToInt32(textBox2.Text);

            hra = (basicsalary * 35) / 100;
            label3.Text =  " hra  =  " + hra;

            
            da = (basicsalary * 45) / 100;
            label4.Text =  " da =  " + da;

            totalsalary = basicsalary + hra + da;
            label5.Text =  " total salary is : " + totalsalary;


        }
    }
}
