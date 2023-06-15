using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using storelibrary;

namespace TrustProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getVendor_Id();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = VendorClass.insertVendor_Mast(TextBox2.Text);
            Label1.Text = res;
            getVendor_Id();
            TextBox1.Text = "";
        }
        public void getVendor_Id()
        {
            int res = Convert.ToInt32(VendorClass.getVendor_Id());
            res = res + 1;
            TextBox1.Text = res.ToString(); 
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = VendorClass.updateVendor_mast(TextBox1.Text, Convert.ToInt32(TextBox2.Text));

            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           string res = VendorClass.deleteVendor_mast(Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = VendorClass.searchVendor_mast(Convert.ToInt32(TextBox2.Text));

            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox1.Text = ds.Tables["Vendor_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "No record exist";
            }
        }

        /*protected void Button3_Click(object sender, EventArgs e)
        {
            string res = VendorClass.deleteVendor_mast(Convert.ToInt32(TextBox2.Text));
            Label1.Text = res; 
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = VendorClass.searchVendor_mast(Convert.ToInt32(TextBox2.Text));

            if (ds.Tables[0].Rows. Count !=0)
            {
                TextBox1.Text = ds.Tables["Vendor_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "No record exist";
            }
        }*/
    }
}