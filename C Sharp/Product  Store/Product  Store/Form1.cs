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

namespace Product__Store
{
    public partial class Form1 : Form
    {
        //creating an enum Nationality
        enum Nationality { Indian, NRI }

        Nationality nationality;

        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.GetTableProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";
            comboBox1.ValueMember = "Product_Category_ID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.GetTableProductName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";
            comboBox2.ValueMember = "Product_ID";

            //filling the GST textBox 
            DataSet ds1 = ProductStore.GetGSTDetails(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["cgst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());
            }
            if (nationality == 0)
            {
                tgst = cgst + sgst;
            }
            else
            {
                tgst = igst;
            }
        }


        //filling the product price in textbox
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = ProductStore.GetPrice(comboBox2.Text);
            foreach(DataRow dr in ds1.Tables[0].Rows)
            {
                textBox3.Text = dr["Product_Price"].ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox7.Text = cgst.ToString();
            textBox8.Text = sgst.ToString();

            textBox9.Text = Convert.ToString(Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text));

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox7.Text = cgst.ToString();
            textBox8.Text = sgst.ToString();
            textBox9.Text = igst.ToString();
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(textBox3.Text =="")
            {

            }
            else
            {
                calculate_total();
            }
        }
        public void calculate_total()
        {
            double total_amount = Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox4.Text);
            textBox5 = total_amount.ToString();

            double total_amount = Convert.ToDouble(textBox3) * Convert.ToDouble(textBox7) / 100;
            textBox10.Text = cgstAmount.ToString();

            double total_amount = Convert.ToDouble(textBox3) * Convert.ToDouble (textBox8) / 100;
            textBox11.Text = sgst_amount.ToString();

            double total_amount = Convert.ToDouble(textBox3) * Convert.ToDouble(textBox9) / 100;
            textBox12.Text = igst_amount.ToString();



            double net_amount = 0;

            if(nationality == 0)
            {
                net_amount = Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox7.Text);
            }
            else
            {
                net_amount = Convert.ToDouble(textBox)
            }
        }
    }
}




