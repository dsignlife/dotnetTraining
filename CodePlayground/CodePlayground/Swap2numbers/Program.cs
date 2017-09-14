using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap2numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 3;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = " + a.ToString());
            Console.WriteLine("b = " + b.ToString());
        }
    }
}
