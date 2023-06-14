using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server = .\\sqlexpress; integrated security = true; database;");
        DataSet ds = new DataSet();
        SqlDataAdapter sda;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Department_Mast values (@Department_Name)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Department_Name", TextBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted.";
            TextBox1.Text = "";
            TextBox1.Focus();
            //load data...

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Department_mast set department_Name = @Department_Name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Department_Name", TextBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted.";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from Department_Mast@Department_Name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Department_Name", TextBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted.";
            TextBox1.Text = "";
            TextBox1.Focus();
        }
    }
}