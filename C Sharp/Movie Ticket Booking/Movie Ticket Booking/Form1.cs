using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Movie_Ticket_Booking
{
    public partial class Form1 : Form
    {
        //Form2 form2 = null;
        public Form1()
        {
            InitializeComponent();
            this.InitiazationEvents();
        }

        private void InitiazationEvents()
        {
            this.comboBox1.Click += ComboBox1_Click;
            

            //throw new NotImplementedException();
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox5.Hide();

            //form = new Form2();
            //form2.ShowDialog();
            groupBox2.Show();
            label7.Text = comboBox1.Text;
            label8.Text = comboBox2.Text;
            label9.Text = comboBox3.Text;
            label10.Text =numericUpDown1.Value.ToString();
            

            Movie_Ticket mt = null;
            if (radioButton1.Checked)
            {
                mt = new online_Booking(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(textBox1.Text));
            }
            else if (radioButton2.Checked)
            {
                mt = new Box_Office(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(textBox1.Text));
            }

            label11.Text = "Total Amount :  " + mt.calculate_Ticket_Price();
            count = 1;
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            switch (comboBox1.Text)
            {
                case "Aashram":
                    comboBox2.Items.Add("Rajesh");
                    comboBox2.Items.Add("TCC");
                    pictureBox1.Show();
                    pictureBox2.Hide();
                    pictureBox3.Hide();
                    pictureBox4.Hide();

                    break;

                case "Bhaijaan":
                    comboBox2.Items.Add("Carnival");
                    comboBox2.Items.Add("INox");
                    pictureBox3.Show();
                    pictureBox2.Hide();
                    pictureBox1.Hide();
                    pictureBox4.Hide();

                    break;

                case "Ved":
                    comboBox2.Items.Add("Shree Talkies");
                    comboBox2.Items.Add("Liberty");
                    pictureBox2.Show();
                    pictureBox1.Hide();
                    pictureBox3.Hide();
                    pictureBox4.Hide();

                    break;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            comboBox3.Items.Clear();

            switch (comboBox2.Text)
            {
                case "Rajesh":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("6.00 PM");
                    textBox1.Text = "200";
                    break;

                case "TCC":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("6.00 PM");
                    textBox1.Text = "400";
                    break;

                case "Carnival":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("6.00 PM");
                    textBox1.Text = "150";
                    break;

                case "INox":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("6.00 PM");
                    textBox1.Text = "500";
                    break;

                case "Shree Talkis":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("6.00 PM");
                    textBox1.Text = "100";
                    break;

                case "Liberty":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("6.00 PM");
                    textBox1.Text = "300";
                    break;

            }

        }
        int count = 0;
        private void button2_Click(object sender, EventArgs e)
        {
          if(count >0)  
            MessageBox.Show("Your Ticket Booked Successfully");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            }
            

            private void Form1_Load(object sender, EventArgs e)
            {
            pictureBox5.Show();
            pictureBox4.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
           // groupBox2.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
    }

