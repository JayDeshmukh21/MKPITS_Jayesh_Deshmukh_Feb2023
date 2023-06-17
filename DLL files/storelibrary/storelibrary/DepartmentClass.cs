using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace storelibrary
{
    public static class DepartmentClass
    {
        static SqlConnection con = Class1.getConnection();
        static string query = null;
        static SqlCommand cmd = null;

        //method to insert record in the vendor table
        public static string insertDepartment_Mast(string Department_Name)
        {
            string res = null;
            try
            {
                query = "insert into Department_mast values(@Department_name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Department_name", Department_Name);
                con.Open();
                cmd.ExecuteNonQuery();

                res = "record saved in department master successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;
        }

        //method to return department id
        public static string getDepartment_Id()
        {
            string res = null;
            try
            {
                query = "select max(Department_Id) from Department_mast";
                cmd = new SqlCommand(query, con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());

                res = vid.ToString();
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;
        }

        //method to update record in Department table
        public static string updateDepartment_mast(string Department_Name, int Department_Id)
        {
            string res = null;

            //checking whether vendor id exist or not

            query = "select count(*) from Department_mast where Department_Id = @Department_Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@vendor_id", Department_Id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {
                try
                {
                    query = "update Department_mast set Department_Name=@Department_Name where Department_Id = @Department_Id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Department_Name", Department_Name);
                    cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in vendor master sussessfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();
                }

            }
            else
            {
                res = "no record exist";
            }
            return res;
        }
        //method to delete record in vendor master
        public static string deleteDepartment_mast(int Department_Id)
        {
            string res = null;


            //checking whether vendor_id exist master
            query = "select count (*) from Department_mast where Department_Id=@Department_Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (cnt > 0)
            {
                try
                {
                    query = "delete from Department_mast where Department_Id = @Department_Id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    res = "record deleted in Department master successfully";

                }
                catch (Exception ex)
                {
                    res = ex.ToString();

                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                res = "no record exist";
            }
            return res;

        }
    }
}
