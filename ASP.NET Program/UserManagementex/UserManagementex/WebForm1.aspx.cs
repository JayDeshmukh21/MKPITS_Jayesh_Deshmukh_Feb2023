using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserManagementex
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie1 = new HttpCookie("cook");
            cookie1.Values.Add("Username",TextBox1.Text);
            Response.Cookies.Add(cookie1);
            Label1.Text = "Temporary cookie add to the client machine";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Code to retrieve cookie from client machine

            HttpCookie cookie1 = Request.Cookies["cook"];
            if(cookie1 != null)
            {
                string uname = cookie1.Values["Username"];
                Label1.Text = uname;
            }
            else
            {
                Label1.Text = "Cookie not exist";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //code to create temporary cookie

            HttpCookie cookie2 = new HttpCookie("cook2");
            cookie2.Values.Add("Username", TextBox1.Text);
            cookie2.Values.Add("Email",TextBox2.Text);
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 1, 0);
            cookie2.Expires = dt.Add(ts);
            Label1.Text = "Cookie add to the client machine permanantly";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpCookie cookie2 = Request.Cookies["cook2"];
            string uname = cookie2.Values["Username"].ToString();
            string email = cookie2.Values["Email"].ToString();
            if(cookie2 != null)
            {
                Label1.Text = uname.ToString();
                Label2.Text = email.ToString();
            }
           else
            {
                Label1.Text = "Cookie not exist";
            }
        }
    }
}