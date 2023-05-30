using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado_static_class_and_method
{
    public static class DatabaseConnection
    {
        /// <summary>
        /// creating a static variable
        /// </summary>
        public static string connectionString = "server = .\\sqlexpess; integrated security = true; database = flipcart;";

        // creating static method 
        public static SqlConnection
    }
}
