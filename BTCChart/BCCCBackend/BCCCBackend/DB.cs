using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BCCCBackend
{
    class DB
    {
        public static SqlConnection GetConnect()
        {
            string cs =
              @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BTCBack;Data Source = localhost\SQLEXPRESS";
            SqlConnection connection = new SqlConnection(cs);
            connection.Open();
            WriteLine("Connecting established");


            

            return connection;



        }

        public static void Show()

        {
           
        }

        public static void Update(SqlConnection connection)
                
        {

            WriteLine("Exucuting Query");
            string query = "";
            SqlCommand command = new SqlCommand(query, connection);
            


            connection.Close();
           
        }
    }
}

