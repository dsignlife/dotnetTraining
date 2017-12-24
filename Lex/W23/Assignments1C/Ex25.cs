using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex25
    {
        /*Write a program that produces the output below using a for-loop
         -----
         ----
         ---
         --
         -
         */

        public Ex25(){

            for (int i = 0; i < 6; i++)
            {
                for( int d= 0; d < i; d++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                }

        }

    }
}
