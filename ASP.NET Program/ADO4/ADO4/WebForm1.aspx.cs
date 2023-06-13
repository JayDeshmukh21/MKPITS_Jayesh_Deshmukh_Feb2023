using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=fendhaldb");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
         
            {
            loaddata();
        }
            public void loaddata()
            {
                str = "select * from tableproduct";
                da =
                new SqlDataAdapter(str, con);
                da.Fill(ds, "tableproduct");
                GridView1.DataSource = ds.Tables["tableproduct"].DefaultView;
                GridView1.DataBind();
            }

        
    }
}