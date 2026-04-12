using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Dapper_Assignment
{
    public class DbConnection
    {
        public static IDbConnection GetConnection()
        {
            return new SqlConnection("Server=DESKTOP-DA9RDQ5\\SQLEXPRESS;Database=BookDB;Trusted_Connection=True;");
        }
    }
}
