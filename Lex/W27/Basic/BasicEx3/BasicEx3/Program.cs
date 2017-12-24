using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEx3
{
    /// <summary>
    /// Class Program.
    /// Write a program to take a series of numbers from user and display the highest of all the numbers
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int hNum = 0;
            while (true)
            {
                Console.Write("Enter a number: ");

                try
                {
                    int num = Int32.Parse(Console.ReadLine());
                    if (num == 0)
                        break;
                    if (num > hNum)
                        hNum = num;
                    Console.WriteLine($"Highest of all numbers is : {hNum}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                    
                }


                
                // stop if user's input is 0

            }
            
        }
    }
}
