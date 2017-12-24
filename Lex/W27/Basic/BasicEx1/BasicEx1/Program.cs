using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEx1
{
    /// <summary>
    /// Class Program./
    /// Accept inches from user and display the equivalent centimeters
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert inches to cm: ");
           
            try
            {
                double inch = double.Parse(Console.ReadLine());
                //double cen = inch * 2.54;
                Console.WriteLine($"{inch} inches = {inch*2.54} cm.");


            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
                throw;
            }

            Console.ReadKey();


        }
    }
}
