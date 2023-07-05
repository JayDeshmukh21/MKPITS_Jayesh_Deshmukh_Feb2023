using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC.Models
{
    public class ItemDBHandler
    {
        SqlConnection con = null;
        public void connection()
        {
            string Constr = "server=.\\sqlExpress;integrated security=true;database=MVC;";
            con = new SqlConnection(Constr);
        }
        //insert item method to insert record into itemlist table
        public bool InsertItem(ItemModel iList)
        {
            connection();
            string query = "insert into ItemList values ('" + iList.Name + "','" + iList.Category + "','" + iList.Price +"' )";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //list generic class to create collection of item model objects
        public List<ItemModel> GetItemsList()
        {
            connection ();
            List<ItemModel> iList = new List<ItemModel>();
            string query = "SELECT * FROM ItemList";
            SqlCommand cmd = new SqlCommand (query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open ();
            adapter.Fill (dt);
            con.Close ();

            foreach(DataRow dr in dt.Rows)
            {
                iList.Add
                    (new ItemModel
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                }
                    );
            }
            return iList;
        }
       
    }
}