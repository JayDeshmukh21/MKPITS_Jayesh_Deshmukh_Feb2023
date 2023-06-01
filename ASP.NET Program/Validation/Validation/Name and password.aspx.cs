using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation.Properties
{
    public partial class Name_and_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("name : " + TextBox1.Text + "<br>");
            sb.Append("email : " + TextBox5.Text + "<br>");
            Label1.Text = sb.ToString();
            if (Page.IsValid)
            {
                Label1.Text = TextBox6.Text;
            }
            else
            {
                Label1.Text = "page is not valid";
            }

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string val = args.Value;
            int len = args.Value.Length;
            if(len ==10)
            {
                string d = val.Substring(0, 2);
                int dd = Convert.ToInt32(d);
                if(dd >31)
                {
                    args.IsValid = false;
                }
                else
                {
                    string m = val.Substring(3, 2);
                    int mm = Convert.ToInt32(m);
                    if(mm > 12)
                    {
                        args.IsValid = false;
                    }
                    else
                    {
                        string y = val.Substring(6, 4);
                        int yy = Convert.ToInt32(y);
                        if(yy == 4)
                        {
                            args.IsValid = false;
                        }
                        else
                        {
                            args.IsValid = false;
                        }
                    }
                }
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}