using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace staticconnectionex2
{
    public static class DatabaseConnection

    #region ====Methods====

    {/// <summary>
     ///creating a static variable
     /// </summary>

        private static string connectionstring = "server = .\\sqlexpress; integrated security = true; database = flipcart;";
        
        ///<summary>
        ///creating a static method
        ///</summary>
        
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection (connectionstring ); ;
            try
            {
                con.Open ();
                return con;
            }
            catch(Exception ex)
            {
                return null;
            }

        }
        ///<summary>
        ///creating a static method to insert record into users table
        ///</summary>
        
        public static string InsertRecord (string username, string password)
        {
            SqlConnection con = GetConnection();

            //creating a insert command
            string query = "insert into users values(@username, @password)";

            //@username and @password are sqlparameters

            try
            {
                //creating an object of sqlcommand class

                SqlCommand command = new SqlCommand(query, con);

                //defining sql parameters
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                //executing the command using execute non query method 

                command.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                con.Close ();
            }
        }

    }
}
#endregion