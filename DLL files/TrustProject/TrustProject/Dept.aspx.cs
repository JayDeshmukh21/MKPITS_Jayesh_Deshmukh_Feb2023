using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using storelibrary;

namespace TrustProject
{
    public partial class Dept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
            //    getDepartmentId();
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
       

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = DepartmentClass.insertDepartment_Mast(TextBox2.Text);
            Label1.Text = res;
            //getDepartmentId();
            TextBox1.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = DepartmentClass.updateDepartment_mast(TextBox2.Text, Convert.ToInt32(TextBox1.Text));

            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string res = DepartmentClass.deleteDepartment_mast(Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
        }

        //public void getDepartmentId()
        //{
        //    int res = Convert.ToInt32(DepartmentClass.getDepartment_Id());
        //    res = res + 1;
        //    TextBox1.Text = res.ToString();
        //}
    }
}