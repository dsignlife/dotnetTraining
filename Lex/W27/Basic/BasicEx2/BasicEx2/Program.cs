using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEx2
{
    /// <summary>
    /// Class Program.
    /// Write a program to take a number and display highest factor for that number
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to show highest factor: ");


            try
            {
                int input = Int32.Parse(Console.ReadLine());

                for (int i = input/2; i > 0; i--)
                {
                    if (input % i == 0)
                    {
                        Console.WriteLine($"Highest factor for {input} is {i}");
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          

            Console.ReadKey();



        }
    }
}
