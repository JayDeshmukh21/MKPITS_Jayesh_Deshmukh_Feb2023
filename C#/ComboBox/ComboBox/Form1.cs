using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=Convert.ToString(textBox1.Text);
            label6.Text = "Your name is : " + name;
            label9.Text = "Country : " + comboBox1.Text;
            label10.Text = "State : " + comboBox2.Text;
            label12.Text = "City : " + comboBox3.Text;
            label13.Text = "Phone no. : " + maskedTextBox1.Text;
            label14.Text = "Date : " + dateTimePicker1.Text;
            label15.Text = "Course : " + comboBox4.Text;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string country=comboBox1.Text;
            switch(country)
            {
                case "India":
                    comboBox2.Items.Add("Maharashtra");
                    comboBox2.Items.Add("Goa");
                    break;

                case "Singapore":
                    comboBox2.Items.Add("Central Region");
                    comboBox2.Items.Add("East Region");
                    break;

                case "Emirates":
                    comboBox2.Items.Add("Abu Dhabi");
                    comboBox2.Items.Add("Dubai");
                    break;

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            comboBox3.Items.Clear();
            string state = comboBox2.Text;

            switch(state)
            {
                case "Maharashtra":
                    comboBox3.Items.Add("Mumbai");
                    comboBox3.Items.Add("Nagpur");
                    break;

                case "Goa":
                    comboBox3.Items.Add("Panjim");
                    comboBox3.Items.Add("Vasco");
                    break;

                case "Central Region":
                    comboBox3.Items.Add("CR1");
                    comboBox3.Items.Add("CR2");
                    break;

                case "East Region":
                    comboBox3.Items.Add("ER1");
                    comboBox3.Items.Add("ER2");
                    break;

                case "Abu Dhabi":
                    comboBox3.Items.Add("Abu Dhabi city");
                    comboBox3.Items.Add("AL Ain");
                    break;

                case "Dubai":
                    comboBox3.Items.Add("Sharjah");
                    comboBox3.Items.Add("Dubai city");
                    break;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
