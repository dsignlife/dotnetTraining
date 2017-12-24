using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex27
    {
        /*Write a program that asks the user for a number. Then display all numbers that the number is divisible by. 
         * Example entering 12, should output 6, 4, 3, 2 and 1. Tip: Use modulo.*/
        public Ex27()
        {
                       

            Console.WriteLine("Enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            int count = input;

            for (int i = 0; i < input; i++)

                            
                
            {
                if (input != count && input % count == 0)
                {
                    Console.Write(count+" ");
                }


                count--;
            }

        }
    }
}
