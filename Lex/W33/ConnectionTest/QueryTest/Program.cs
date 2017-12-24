using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



namespace QueryTest
{
    class Program
    {

       

        static void Main(string[] args)
        {
            GetSchema(GetNorthwnd.GetConnection());
         //   GetEmployees(GetNorthwnd.GetConnection());
        }



        
        public static void GetSchema(SqlConnection connection)
        {
            string sqlquery = "SELECT * FROM Employees";
            var cmd = new SqlCommand(sqlquery, connection);
            SqlDataAdapter a = new SqlDataAdapter(sqlquery, connection);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable table = dataReader.GetSchemaTable();
            //var row = table.TableName;

            foreach (var data in table.Columns.ToString())
            {
                WriteLine(data.ToString());
            }   

        }



        public static void GetEmployees(SqlConnection connection)

        {



            WriteLine("Creating and Exucuting Query");
            string showData = String.Format("select * from Employees");
            SqlCommand command = new SqlCommand(showData, connection);
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {

                    WriteLine(dataReader["EmployeeID"]);
                    WriteLine(dataReader["FirstName"]);
                    WriteLine(dataReader["LastName"]);
                    WriteLine(dataReader["Title"]);
                    //WriteLine(dataReader[]);
                }
            }

            connection.Close();
            
        }

    }
}
