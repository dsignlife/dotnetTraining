using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex13
    {
        /*Write a program that lets a user type in a number and check whether this number is divisible by 4 and display the result to the user.*/

        public Ex13()
        {
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input % 4 == 0)
            {
                Console.WriteLine(input + " can be divided by 4");
            }
            else
            {
                Console.WriteLine(input + " can't be divided by 4");
            }
            }

    }
}
