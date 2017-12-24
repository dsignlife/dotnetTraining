using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace NorthwndTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetSchema(GetNorthwnd.GetConnection());
            GetEmployees(GetNorthwnd.GetConnection());
            
        }




        //public static void GetSchema(SqlConnection connection)
        //{
        //    string sqlquery = "SELECT * FROM Employees";
        //    var cmd = new SqlCommand(sqlquery, connection);
        //    SqlDataAdapter a = new SqlDataAdapter(sqlquery, connection);
        //    SqlDataReader dataReader = cmd.ExecuteReader();
        //    DataTable table = dataReader.GetSchemaTable();
        //    //var row = table.TableName;

        //    foreach (var data in table.Columns.ToString())
        //    {
        //        WriteLine(data.ToString());
        //    }

        //}



        public static void GetEmployees(SqlConnection connection)

        {



            WriteLine("Creating and Exucuting Query");
            string showData = String.Format("select * from Employees");
            SqlCommand command = new SqlCommand(showData, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            Employee emp = new Employee
            {
                
                Employees1 = new List<Employee>()
            };





            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {

                    emp.Employee1 = new Employee();
                    WriteLine(dataReader["EmployeeID"]);
                    emp.Employee1.EmployeeID = Convert.ToInt32(dataReader["EmployeeID"]);
                    WriteLine(dataReader["FirstName"]);
                    emp.Employee1.FirstName = dataReader["FirstName"].ToString();
                    WriteLine(dataReader["LastName"]);
                    WriteLine(dataReader["Title"]);
                    //WriteLine(dataReader[]);

                emp.Employees1.Add(emp.Employee1);

                }
            }
            

            WriteLine("******************");
            foreach (var data in emp.Employees1)
            {
                WriteLine("Result");
                WriteLine(data.EmployeeID +" "+ data.FirstName);
            }

            connection.Close();

        }
    }
}
