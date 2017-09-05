using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30daystestcode
{
    class d3
        {


      public d3()
            
        {
            Random r = new Random();
           int N = r.Next(1, 24);
           Console.WriteLine(N);

            //If  n is odd, print Weird
            //If   n is even and in the inclusive range of  to , print Not Weird
            //If  n is even and in the inclusive range of  to , print Weird
            //If n  is even and greater than , print Not Weird


            if (IsOdd(N))
            {
                Console.WriteLine("Weird");
            }

            else if (IsEven(N) && (N >= 2 && N <= 5))

            {
                Console.WriteLine("Not Weird");
            }
           else  if (IsEven(N) && (N >= 6 && N <= 20))

            {
                Console.WriteLine("Weird");
            }
            else if (IsEven(N) && (N > 20))
            {
                Console.WriteLine("Not Weird");
            }

            else Console.WriteLine("NO");



        }
        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}

