using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Product__Store
{
    public static class ProductStore
    {
        private static string connectionstring = "server = .\\sqlexpress; integrated security = true; database = Single_UI;"; 

        //method to crate connection
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                return con;
            }
            catch(Exception ee)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        //method to return product category
        public static DataSet GetTableProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "select * from TableProductCategory ";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(ds, "TableProductCategory");
            return ds;
        }
        //method to return product name for given product category 
        public static DataSet GetTableProductName(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select p.Product_ID, Product_Name from TableProduct p inner join TableProductCategory t on p.Product_Type_ID = t.Product_Category_ID where t.Product_Type_Name = @Product_Type_Name ";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter (query, con);
            sda.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            sda.Fill(ds, "TableProduct");
            return ds;
        }
        //method to return Gst Details for given Product_Type_Name
        public static DataSet GetGSTDetails(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = " select p.cgst, p.sgst, p.igst from TableProductGSTDetails p inner join TableProductCategory j on p.Product_Gst_ID = j.Product_Gst_ID where Product_Type_Name = @Product_Type_Name";

            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter (query, con);
            sda.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            sda.Fill(ds, "TableProductGSTDetails");
            return ds;
        }
        //method to return price for given product
        public static DataSet GetPrice(string Product_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select Product_Price from TableProduct where Product_Name = @Product_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter (query, con);
            sda.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
            sda.Fill(ds, "TableProduct");
            return ds;
        }
    }
}
