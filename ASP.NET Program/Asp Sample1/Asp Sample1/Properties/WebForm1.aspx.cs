using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Sample1.Properties
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
           int n=Convert.ToInt32(TextBox1.Text);
            if (n == 0 )
            {
                Label1.Text = "please put proper age";
            }
            else if (n>21)
            {
                Label1.Text = "You are eligible to vote"; 
            }
            else
            {
                Label1.Text = "you are not eligible";
            }
            
        }
    }
}