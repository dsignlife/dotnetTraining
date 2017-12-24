using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex21
    {
        /*Write a program that lets the user enter a number. Check that it is greater than zero.
         * Lastly, iterate from that number down to zero and output each number. That means, 10 should give back the result 9,8,7,6,5,4,3,2,1 and 0.*/

        public Ex21()
        {
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            var list = new List<int>();

            if (input > 0)
            {
                for (int i = 1; i <= input; i++)
                {
                    list.Add(input - i);
                }
                
                for (int d = 0; d < input; d++)
                {
                    Console.Write(list[d] + ",");
                }
            }
        }
    }
}
