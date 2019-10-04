using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftBlade.DB
{
     class  Connection
    {
       
        public static SqlConnection SqlConnection()
        {
            string connectionString = @"Data Source = .\SQLSERVER; Initial Catalog = SoftBlade; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionString); 
             conn.Open();
            try
            {
                if (conn.State == ConnectionState.Open)
                    Console.WriteLine("Connection Suceess");
            }
            catch (SqlException e)
            {
               Console.WriteLine(e.Message);
            }
            return conn;
        }



    }
}
