using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class ConnectionSingleton
    {
        static SqlConnection conn;
        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder["Data Source"] = "LAPTOP-RR1781P4\\SQLEXPRESS";
                builder["integrated Security"] = true;
                builder["Initial Catalog"] = "Restaurant";
                builder.UserID = "LAPTOP-RR1781P4\\SQLEXPRESS";
                conn = new SqlConnection(builder.ConnectionString);
                conn.Open();
                return conn;
            }
            else
                return conn;
        }
    }
}
