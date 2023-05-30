using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Institute_Registration
{
    public partial class Form1 : Form
    {
        enum SCategory { Student, IT_Professional }
        SCategory category;


        enum SGender { Male, Female, Other }
        SGender gender;

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "1000";

            DataSet ds = new DataSet();
            ds = CourseRegistration.GetNation();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationID";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DataSet ds = new DataSet();
            //ds = CourseRegistration.GetState(comboBox1.Text);
            //comboBox2.DataSource = ds.Tables[TableNation];
            //comboBox2.DisplayMember = "StateName";
            //comboBox2.ValueMember = "StateID";

            //DataSet ds= CourseRegistration.GetState(comboBox1.Text);
            //comboBox2.DataSource = ds.Tables["TableState"];
            //comboBox2.DisplayMember = "StateName";
            //comboBox2.ValueMember = "StateID";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = CourseRegistration.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables["TableCity"];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityID";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataSet ds = CourseRegistration.GetState(comboBox1.Text);
            comboBox2.DataSource = ds.Tables["TableState"];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                category = SCategory.Student;
                textBox2.Text = "1000";
            }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                category = SCategory.IT_Professional;
                textBox2.Text = "3000";

            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            check_balance_amount();
        }


        double total_amount = 0;
        double fp = 0;
        double bal_amount = 0;
        public void check_balance_amount()
        {
            total_amount = Convert.ToDouble(textBox2.Text);
            fp = 0;
            if (category == 0)
            {
                fp = total_amount * 50 / 100.00;
            }
            else
            {
                fp = total_amount * 80 / 100.00;
            }
            if (Convert.ToDouble(textBox3.Text) < fp)
            {
                MessageBox.Show("Paid amount should be atlest 50% for student and 80% for IT professional");
            }
            else
            {
                bal_amount = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                textBox4.Text = bal_amount.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check_user_details();
            //MessageBox.Show("successfull");
        }
        public void check_user_details()
        {
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill all details");
            }
            else
            {
                string result = CourseRegistration.saveTableCourseRegDetail(Convert.ToInt32(category), textBox1.Text,Convert.ToInt32(gender));
                //MessageBox.Show(result);
                result = CourseRegistration.saveTableRegAddress(Convert.ToInt32(comboBox1.SelectedValue),Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
                //MessageBox.Show(result);
                result = CourseRegistration.saveTableFeeDetail(Convert.ToDouble(textBox2.Text), fp, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text) , dateTimePicker1.Value);
                MessageBox.Show("successfull");

            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                gender = SGender.Male;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                gender = SGender.Female;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                gender = SGender.Other;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
       
  
