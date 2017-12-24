using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex23
    {
        /**/

        public Ex23()
        {
            for(int i = 1; i <= 10; i++)
            {

               for (int d = 1; d <=10; d++)
                {
                    Console.Write(i + "*" + d + "=" +(i*d)+ " ");
                }
                Console.WriteLine();
            }
        }


    }
}
