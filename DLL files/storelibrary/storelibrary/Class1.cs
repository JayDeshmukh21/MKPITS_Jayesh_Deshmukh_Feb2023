using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace storelibrary
{
    public class Class1
    {
        public static SqlConnection con;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("server = .\\sqlexpress; integrated security = true ; database = TrustDB;");
            return con;
        }
    }
}
