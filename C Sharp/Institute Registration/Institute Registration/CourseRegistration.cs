using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Http.Headers;

namespace Institute_Registration
{
    internal class CourseRegistration
    {
        private static string connectionstring = "server = .\\sqlexpress; integrated security = true; database = Institute Reg;";
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                return con;
            }
            catch
            {
                return null;
            }
        }
        public static DataSet GetNation()
        {
            string query = "select * from TableNation";
            SqlConnection con = new SqlConnection(connectionstring);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(ds, "TableNation");
            return ds;
        }
        public static DataSet GetState(string NationName)
        {
            SqlConnection con = GetConnection();
            string query = "select s.StateName, s.StateID from TableState s inner join TableNation n on s.NationID = n.NationID where NationName = @NationName";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@NationName",NationName);
            sda.Fill(ds, "TableState");
            return ds;
        }
        public static DataSet GetCity(string StateName)
        {
            SqlConnection con = GetConnection();
            string query = "select c.CityName ,c.CityID from TableCity c inner join TableState s on s.StateID = c.StateID where s.StateName = @StateName";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@StateName",StateName);
            sda.Fill(ds, "TableCity");
            return ds;
            
        }
        //method to save record in tablecourseregdetails
        public static string saveTableCourseRegDetail(int CategoryID, string FullName, int GenderID)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into TableCourseRegDetails values(@categoryid,@fullname,@genderid)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@categoryid", CategoryID);
            command.Parameters.AddWithValue("@fullname", FullName);
            command.Parameters.AddWithValue("@genderid", GenderID);

            command.ExecuteNonQuery();
            con.Close();
            return null;

        }


        //method to save record in tableregaddress
        static int CourseID = 0;
        public static string saveTableRegAddress(int NationID, int StateID, int CityID)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "SELECT top 1  CourseRegID FROM TableCourseRegDetails ORDER BY CourseRegID DESC ";
            SqlCommand command = new SqlCommand(query, con);
            CourseID = Convert.ToInt32(command.ExecuteScalar());
            query = "insert into TableRegAddress values(@courseregid,@nationid,@stateid,@cityid)";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@courseregid", CourseID);
            command.Parameters.AddWithValue("@nationid", NationID);
            command.Parameters.AddWithValue("@stateid", StateID);
            command.Parameters.AddWithValue("@cityid", CityID);

            command.ExecuteNonQuery();
            con.Close();
            return null;
     

        }


        //method to save record in tablefeedetail
        public static string saveTableFeeDetail(double total_amount, double minper, double paidamount, double bal_amount, DateTime paiddate)
        {
            SqlConnection con = GetConnection();
            con.Open();

            string query = "insert into TableFeeDetail values(@courseregid,@totalamount,@minper,@paidamount,@balamount,@paiddate)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@courseregid", CourseID);
            command.Parameters.AddWithValue("@totalamount", total_amount);
            command.Parameters.AddWithValue("@minper", minper);
            command.Parameters.AddWithValue("@paidamount", paidamount);
            command.Parameters.AddWithValue("@balamount", bal_amount);
            command.Parameters.AddWithValue("@paiddate", paiddate);


            command.ExecuteNonQuery();
            con.Close();
            return null;
        }

    }
}
