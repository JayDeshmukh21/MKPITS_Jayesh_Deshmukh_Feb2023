using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_for_country
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string country = comboBox1.Text;
            // MessageBox.Show(country);
            switch (country)
            {
                case "India":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Mumbai");
                    comboBox2.Items.Add("Pune");
                    break;
                case "Usa":
                    comboBox2.Items.Add("La");
                    comboBox2.Items.Add("Newyork");
                    comboBox2.Items.Add("Chicago");
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "country : " + comboBox1.Text + "\n";
            label4.Text += "city : " + comboBox2.Text + "\n";

            label4.Text += "course : " + listBox1.SelectedItem.ToString() + "\n";
            label4.Text += "Date : " + dateTimePicker1.Text + "\n";
            label4.Text += "phone no : " + maskedTextBox1.Text + "\n";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
        }

        
    }
}
