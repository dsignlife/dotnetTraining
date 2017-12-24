using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex20
    {
        /*Write a program that lets the user enter a number. 
         * Check that it is greater than zero. 
         * Lastly, iterate that many times, and display each number in the iterations. 
         * 10 should then display 0,1,2,3,4,5,6,7,8 and 9 in the console window.*/

        public Ex20()
        {
            
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            var list = new List<int>();

            if (input > 0)
            {
                for (int i = 1; i <= input; i++)
                {
                    list.Add(input-i);
                }
                list.Reverse();
                for (int d = 0; d < input; d++)
                {
                    Console.Write(list[d]+ ",");
                }
            }
        }
    }
}
