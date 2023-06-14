using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample_DLL;

namespace UsingDllex
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            Label1.Text = c.addition(Convert.ToInt32(TextBox1.Text),Convert.ToInt32(TextBox2.Text));

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Class1 c =new Class1();
            Label1.Text = c.substraction(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            Label1.Text = c.Division(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            Label1.Text = c.Multiply(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        }
    }
}