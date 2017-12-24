using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex10
    {
        public Ex10()
        {
            /*What is the output of the following code? Try think about it before trying to run the code.*/
             int a = 10; 
             int b = 3;
             int c = 7;
            //int d = 7 /2.0f; 

            double result = ((double) a / b) * 2; 
            Console.WriteLine(result);

            result = a / (b + c) + 9.0f;
            Console.WriteLine(result);

            result = a * a / (b + c);
            Console.WriteLine(result);

            result = a * (b + a) - 100;
            Console.WriteLine(result);
                

        }
    }
}
