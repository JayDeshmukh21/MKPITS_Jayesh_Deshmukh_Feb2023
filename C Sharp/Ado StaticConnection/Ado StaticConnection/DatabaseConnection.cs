using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado_StaticConnection
{
    public static class DatabaseConnection
    {
        //creating a static variable

        private static string connectionString = "server = .\\sqlexpress; integrated security = true; database = flipcart;";


        //creating a static method

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
    
}
