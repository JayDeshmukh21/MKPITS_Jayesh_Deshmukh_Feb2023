using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample_2.Properties
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int price = Convert.ToInt32(TextBox3.Text);
            int quantity = Convert.ToInt32(TextBox4.Text);
            int total_amount = price * quantity;
            
            Label1.Text = TextBox2.Text;
            Label2.Text = Convert.ToString(total_amount);
            Label3.Text = TextBox1.Text;
        }
    }
}