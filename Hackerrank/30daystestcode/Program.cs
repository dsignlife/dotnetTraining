using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _30daystestcode
{
    class Program
    {
        static void Main(string[] args)
        {

          


                Write("Enter challenge day: ");

                string i = ReadLine();
                try
                {
                    int k = Convert.ToInt32(i);
                }
                catch (FormatException)
                {
                    WriteLine("{0} is not an integer, closing", i);
                    Read();
                    Environment.Exit(0);
                    
                }


                string e = "d" + i;

                WriteLine($"Day number {i}");
                Choose(e);
                Read();


            }

            private static object Choose(string className)
            {
                var assembly = Assembly.GetExecutingAssembly();

                var type = assembly.GetTypes().First(t => t.Name == className);

                return Activator.CreateInstance(type);
            }



           
        }
    }

    

    




