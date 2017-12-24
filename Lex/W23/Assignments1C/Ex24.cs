using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex24
    {
        /*Write a program that iterates 1 to 10 and print each number raised to the power 2. Also output text like:
“5 raised to the power of 2 is equal to 25”*/

        public Ex24()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i+" raised to the power of 2 is equal to " + Math.Pow(i, 2));
            }
        }
    }
}
