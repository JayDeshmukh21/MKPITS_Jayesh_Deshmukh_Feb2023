using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace storelibrary
{
    public static class VendorClass
    {
        static SqlConnection con = Class1.getConnection();
        static string query = null;
        static SqlCommand cmd = null;

        //method to insert record in the vendor table
        public static string insertVendor_Mast(string vendor_name)
        {
            string res = null;
            try
            {
                query = "insert into vendor_mast values(@vendor_name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
                con.Open();
                cmd.ExecuteNonQuery();

                res = "record saved in vendor master successfully";
            }
            catch(Exception  ex)
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;
        }
        //method to return vendor id
        public static string getVendor_Id()
        {
            string res = null;
            try
            {
                query = "select max(Vendor_Id) from Vendor_mast";
                cmd = new SqlCommand(query, con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());

                res = vid.ToString();
            }
            catch(Exception ex)
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;
        }
        //method to update record in vendor table
        public static string updateVendor_mast(string Vendor_name, int Vendor_Id)
        {
            string res = null;

            //chacking wheather vendorid exist or not

            query = "select count(*) from vendor_mast where vendor_id = @vendor_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@vendor_id",Vendor_Id); 
            con .Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close ();

            if(cnt > 0)
            {
                try
                {
                    query = "update vendor_mast set vendor_name=@vendor_name where vendor_id = @vendor_id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Vendor_Name", Vendor_Name);
                    cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in vendor master sussessfully";
                }
                catch(Exception ex)
                {
                    res = ex.ToString ();
                }
                finally
                {
                    con .Close();
                }
                
            }
            else
            {
                res = "no record exist";
            }
            return res;
        }
        //method to delete record in vendor master
        public static string deleteVendor_mast(int Vendor_Id)
        {
            string res = null;

            //checking whether vendor_id exist master
            query = "select count (*) from Vendor_mast where Vendor_Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
            con.Open();
            int cnt = Convert.ToInt32 (cmd.ExecuteScalar());
            con.Close();
            if(cnt > 0)
            {

            }
        }
    }
}
