using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex29
    {
        /*Write a program that asks the user for a number. 
         * Use this number to output the Fibonacci series up until that number. 
         * Entering 10 should then output: 0, 1, 1, 2, 3, 5, 8, 13, 21 and 34.*/

        public Ex29(){

            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < input; i++)
            {
                Console.Write(Fibonacci(i) +", ");
            }
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
