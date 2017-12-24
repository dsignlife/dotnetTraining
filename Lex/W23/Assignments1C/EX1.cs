using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex1
    {
        
        public static void Main(string[] args)
        {

             
            Console.WriteLine("Input Exercise code:");

            string i = Console.ReadLine();
            try
            {
              int k = Convert.ToInt32(i);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not an integer, closing", i);
                Console.Read();
                Environment.Exit(0);
                // Return? Loop round? Exit Whatever.
            }


            string eee = "Ex" + i;// ".Ex" + i; // Set value
            
            Console.WriteLine(eee);
            Choose(eee);
            Console.Read();


        }

        private static object Choose(string className)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes().First(t => t.Name == className);

            return Activator.CreateInstance(type);
        }
    }




}



