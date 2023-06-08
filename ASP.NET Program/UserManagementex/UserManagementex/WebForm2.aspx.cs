using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserManagementex
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie1 = Request.Cookies["cook"];
            if (cookie1 != null)
            {
                string uname = cookie1.Values["Username"];
                Label1.Text = uname;
            }
            else
            {
                Label1.Text = "Cookie not exist";
            }
        }
    }
}