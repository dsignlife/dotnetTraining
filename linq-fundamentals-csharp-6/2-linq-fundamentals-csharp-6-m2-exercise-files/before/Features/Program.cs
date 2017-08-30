using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => 
            {
                int temp = x + y;
                return temp;
            }
            ;

            Action<int> write = x => Console.WriteLine(x);

            write(square(add(3, 5)));

            //Console.WriteLine(square(add(3,5)));
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name= "Scott" },
                new Employee { Id = 2, Name= "Chris" },
                new Employee { Id = 4, Name= "Shris" }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };


            var query = developers.Where(
                e => e.Name.Length == 5)
                .OrderByDescending(e => e.Name)
                .Select(e => e);

            var query2 = from developer in developers
                where developer.Name.Length == 5
                orderby developer.Name descending 
                select developer.Name;


            foreach (var employee in query2)
            {
                Console.WriteLine(employee);
            }

            //foreach (var employee in developers.Where(NameStartsWithS))
            //{
            //    Console.WriteLine(employee.Name);
            //}

        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
