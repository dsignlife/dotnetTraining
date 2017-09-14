using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 538.938648;
            double b = 538.938647;
            bool equal = Math.Abs(a - b) < 0.000001;
            Console.WriteLine(equal);

            double c = 538.938648;
            double d = 538.938646;
            bool equal2 = Math.Abs(c - d) < 0.000001;
            Console.WriteLine(equal2);

            double e = 538.938645;
            double f = 538.938647;
            bool equal3 = Math.Abs(e - f) < 0.000001;
            Console.WriteLine(equal3);
        }
    }
}
