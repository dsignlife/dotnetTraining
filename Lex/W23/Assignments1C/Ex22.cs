using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex22
    {
        /*Write a program that lets the user enter a number. 
         * Check that it is greater than zero.
         * Lastly, iterate that many times, and display each number that is divisible by 2.*/
        public Ex22()
        {
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());


            if (input > 0)
            {

                for (int i = 0; i < input; i++)
                {

                    if (IsEven(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }


            }

        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}
