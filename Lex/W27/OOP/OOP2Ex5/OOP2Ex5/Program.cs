using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Ex5
{
    /// <summary>
    /// Class Program.
    /// Create a function that takes any type of object and
    /// calls Print() method of the given object.
    /// </summary>
    class Program
    {
        //
        static void Main(string[] args)
        {

            var print1 = new Print1();
            var print2 = new Print2();

            print1.Print();
            print2.Print();

        }

        public static void Print(int d)
        {

        }

        public class Print1
        {
            public void Print()
            {

                Console.WriteLine("Print from class Print1");
            }
        }
        class Print2
        {
            public void Print()
            {

                Console.WriteLine("Print from class Print2");
            }
        }
    }
}
