﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Net.Mime;

namespace DrivenITProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server = .\\sqlexpress; integrated security = true; database = DrivenIT;");
        SqlCommand command = null;
        string query = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into transactions1 values ( @Itemid,@Transtype,@Transqty,@Transdate)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Itemid", DropDownList1.SelectedValue);
                string trans = null;
                if(RadioButton1.Checked)
                {
                    trans = "I";

                }
                else if(RadioButton2.Checked)
                {
                    trans = "R";
                }
                command.Parameters.AddWithValue("@Transtype", trans);
                command.Parameters.AddWithValue("@Transqty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("Transdate", TextBox2.Text);
                con.Open();
                command.ExecuteNonQuery();

                //getting the balqty from itemmaster table for particular item id

                query = "select max(balqty) from Itemmaster where Itemid=@Itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (trans == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (trans == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }

                //updating bal qty on item master table
                query = "update Itemmaster set balqty=@balqty where Itemid=@Itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@balqty", bq);
                command.Parameters.AddWithValue("@Itemid", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "record saved";
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update transactions1 set transtype=@transtype,transqty=@transqty,transdate=@transdate where itemid=@itemid";
                command = new SqlCommand(query, con);

                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";
                }
                command.Parameters.AddWithValue("@transtype", transt);
                command.Parameters.AddWithValue("@transqty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@transdate", TextBox2.Text);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                con.Open();
                command.ExecuteNonQuery();

                //getting the balqty from itemmaster table for particular item id
                query = "select max(balqty) from itemmaster where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (transt == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }


                //updating bal qty on item master table
                query = "update itemmaster set balqty=@balqty where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@balqty", bq);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "record updated successfully";
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
            //  TextBoxUserName.Text = GridView1.SelectedRow.Cells[2].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[5].Text;
            DropDownList1.SelectedValue= GridView1.SelectedRow.Cells[3].Text;
        }
    }

}