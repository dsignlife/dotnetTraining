using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NorthwndTest
{
    public class GetNorthwnd
    {
        public static SqlConnection GetConnection()
        {
            string cs =
              @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NORTHWND;Data Source = localhost\SQLEXPRESS";
            SqlConnection connection = new SqlConnection(cs);
            connection.Open();
            WriteLine("Connecting established, intiating Query ");

            return connection;



        }
    }
}
