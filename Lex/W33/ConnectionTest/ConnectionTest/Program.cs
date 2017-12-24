using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using static System.Console;

namespace ConnectionTest
{
    public class Employees
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        


        public Employees()
        {
           
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            GetEmployees(GetConnect());


        }


        public static SqlConnection GetConnect()
        {
            string cs =
             // @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NORTHWND;Data Source = localhost\SQLEXPRESS";
             @"Network Library=DBMSSOCN; Initial Catalog=NORTHWND;
              Data Source = dsignlife.asuscomm.com,1433; User ID= sa; Password= tomz;";
            SqlConnection connection = new SqlConnection(cs);
            connection.Open();
            WriteLine("Connecting established, intiating Query ");

            return connection;



        }
        public static Employees GetEmployees(SqlConnection connection)

        {

            Employees result = new Employees();
          

            WriteLine("Creating and Exucuting Query");
            string showData = String.Format("select * from Employees");
            SqlCommand command = new SqlCommand(showData, connection);
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    result.EmployeeID = Convert.ToInt32(dataReader["EmployeeID"]);
                    WriteLine(result.EmployeeID);
                  //  result.FirstName = dataReader["FirstName"];
                    WriteLine(result.FirstName);
                    result.LastName = dataReader["LastName"].ToString();
                    WriteLine(result.LastName);
                    result.Title = dataReader["Title"].ToString();
                    WriteLine(result.Title);
                   

                }
            }

            connection.Close();
            return result;
        }
    }
}