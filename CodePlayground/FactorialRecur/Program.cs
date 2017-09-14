using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecur
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample number
            int n = 8;

            int r = Factorial(n);
            Console.WriteLine(n + "! = " + r);
        }
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}
