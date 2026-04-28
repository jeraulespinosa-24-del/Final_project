using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                @"Data Source=LAPTOP-TA0T06IO\SQLEXPRESS;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
