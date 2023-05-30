using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado_userDetailForm
{
    public static class EmployeeDetails
    {
        private static string connectionString = "server = .\\sqlexpress; integrated security=true; database=flipcart;";
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        //method to return city name 
        public static SqlDataReader GetCity()
        {
            SqlConnection connection = GetConnection();
            string query = "select * from City";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader jp = command.ExecuteReader();
                return jp;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public static string InsertRecord(int empno, string empname, string gender, string email, string mobileno, string city, string Dob)
        {
            SqlConnection connection = GetConnection();
            string query = "insert into employee values(@empno, @empname, @gender, @email, @mobileno, @city, @Dob)";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@empno", empno);
                command.Parameters.AddWithValue("@empname", empname);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@mobileno", mobileno);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@Dob", Dob);
                command.ExecuteNonQuery();
                return "record inserted successfully";

            }
            catch(Exception jp1)
            {
                return jp1.ToString();
            }
            finally
            {
                connection.Close();
            }

        }
        //creating a static method to update record into user table
public static string UpdateRecord(string empname, string gender, string email, string mobileno, string city, string Dob)
        {
            SqlConnection connection = GetConnection();
            string query = "update employee where  "
        }

    }
}
