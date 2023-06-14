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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server = .\\sqlexpress; integrated security = true; database = TrustDB;");
        DataSet ds = new DataSet();
        SqlDataAdapter sda = new SqlDataAdapter();
        string query = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO Item_master Values(@Item_name,@Category,@Rate,@Balance_quantity)";
                SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item_name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Category", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@Rate",TextBox3.Text);
            cmd.Parameters.AddWithValue("@Balance_quantity",TextBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record inserted successfully";
            GridView1.DataSource = ds.Tables["Item_master"].DefaultView;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = "UPDATE Item_master  SET Item_name = @Item_name, Category = @Category, Rate = @Rate, Balance_quantity = @Balance_quantity";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item_name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Category", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@Rate", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Balance_quantity", TextBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record inserted successfully";
            GridView1.DataSource = ds.Tables["Item_master"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "delete from Item_master where @Item_name, Category = @Category, Rate = @Rate, Balance_quantity = @Balance_quantity";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item_name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Category", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@Rate", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Balance_quantity", TextBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record inserted successfully";
        }
    }
}