using Employee1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Employee1.Controllers
{
    public class HomeController : Controller
    {
        private SqlConnection con;

        //To handle connection releated activities

        private void connection()
        {
            string constr = "server = .\\sqlexpress; integrated security= true; database = CompanyXYZ;";
            con = new SqlConnection(constr);
        }

        #region
        /// <summary>
        /// // GET: Home
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET: AddEmployee
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddEmployee(EmpModel obj)
        {
            AddDetails(obj);
            return View();
        }
        
        private void AddDetails(EmpModel obj)
        {
            connection();
            SqlCommand conn = new SqlCommand("AddEmp", con);

            //addemp is the name of stored procedure
            conn.CommandType = CommandType.StoredProcedure;
            conn.Parameters.AddWithValue("@Name", obj.Name);
            conn.Parameters.AddWithValue("@City", obj.City);
            conn.Parameters.AddWithValue("Address", obj.Address);
            con.Open();
            conn.ExecuteNonQuery();
            con.Close();
        }

        [HttpPost]
        public ActionResult UpdateEmployee(EmpModel obj)
        {
            UpdateDetails(obj);

            return View();
        }
        [HttpPost]
        private void UpdateDetails(EmpModel obj)
        {
            connection();
            SqlCommand com = new SqlCommand("UpdateEmp", con);
            //addemp is the name of stored procedure
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        //[HttpPost]
        //public ActionResult UpdateEmployee(EmpModel obj) //ye view hai
        //{
        //    UpdateDetails(obj);
        //    return View();
        //}
        //[HttpPost]

        //private void UpdateDetails(EmpModel obj) //ye method hai
        //{
        //    connection();
        //    SqlCommand conn = new SqlCommand("UpdateEmp", con);
        //    conn.Parameters.AddWithValue("@Name", obj.Name);
        //    conn.Parameters.AddWithValue("@City", obj.City);
        //    conn.Parameters.AddWithValue("@Address", obj.Address);
        //    con.Open();
        //    conn.ExecuteNonQuery();
        //    con.Close();
        //}

        //[HttpPost]
        //public ActionResult DeleteEmployee(EmpModel obj)
        //{
        //    DeleteDetails(obj);
        //    return View();
        //}
        //private void DeleteDetails(EmpModel obj)
        //{
        //    connection();
        //    SqlCommand conn = new SqlCommand("DeleteEmp", con);
        //    conn.Parameters.AddWithValue("@Name", obj.Name);
        //    conn.Parameters.AddWithValue("@City", obj.City);
        //    conn.Parameters.AddWithValue("@Address",obj.Address);
        //    con.Open();
        //    conn.ExecuteNonQuery();
        //    con.Close();
        //}

        #endregion
    }
}