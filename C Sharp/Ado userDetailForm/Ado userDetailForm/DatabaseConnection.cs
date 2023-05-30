using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado_userDetailForm
{
    public static class DatabaseConnection
    {
        //creating a static variable 
        private static string connectionString = "server = .\\sqlexpress; integrated security = true; database = flipcart;";
        //creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch(Exception jp)
            {
                return null;
            }
        }
        //creating a static method to insert record into user table
        public static string InsertRecord(string username, string password)
        {
            SqlConnection connection = GetConnection();
            //creating a insert command 
            string query = "insert into users(name,password) values(@username, @password)";
            //@username ane @password are sqlparameters
            try
            {
                //creating an object of Sqlcommand class
                SqlCommand command = new SqlCommand(query, connection);
                //defining Sqlparameters
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                //executing the command using ExecuteNonQuery method
                command.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch(Exception jp)
            {
                return jp.ToString();
            }
            finally
            {
                connection.Close();
            }

        }
        //creating a static method to update record into user table
        public static string UpdateRecord(string name, string password)
        {
            SqlConnection connection = GetConnection();
            //creating a insert command
            string query = "update users set password = @password where name = @name";
            //@username and @password are SqlParameters
            try
            {
                //creating an object of SqlCommand class
                SqlCommand command = new SqlCommand(query, connection);
                //defining sql
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();
                return "record update successfully";

            }
            catch(Exception jp)
            {
                return jp.ToString();

            }
            finally
            {
                connection.Close();
            }

        }
        public static string DeleteRecord(string name)
        {
            SqlConnection connection = GetConnection();
            string query = "delete from users where name=@name";

            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();
                return "record deleted successfully";
            }
            catch(Exception jp)
            {
                return jp.ToString();
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
