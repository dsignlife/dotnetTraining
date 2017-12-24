using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex28
    {
        /*Write a program that outputs the 3 first perfect numbers. A perfect number is a number 
         * where all its positive divisors sums up to the actual number. 
         * The first number is 28, where 14 + 7 + 4 + 2 + 1 = 28. Tip: look at the previous exercise and build on top of it.*/

        public Ex28()
        {
            Console.WriteLine("Enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            var list = new List<int>();


            for (int i = 1; i < input; i++)



            {
                if ( input % i == 0)

                {
                    sum =+ i;
                    list.Add(sum);
                    
                }

             
            }

            list.Reverse();
            Console.WriteLine(list[0] + " " + list[1] + " " + list[2]);

        }
    }
}
