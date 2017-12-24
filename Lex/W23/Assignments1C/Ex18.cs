using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex18
    {
        /*Write a program that lets a user type in a number. 
         * Check if the number is in the range 10 <= number <= 20. 
         * Tip: try using both nested if-statements and && to check the range.*/

        public Ex18()
        {

            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (10 <= input && input <= 20 )
            {
                Console.WriteLine(input+ " is in the range 10 <= number <= 20. ");
            }

            else
            {
                Console.WriteLine(input + " is not in the range 10 <= number <= 20. ");
            }
        }
    }
}
