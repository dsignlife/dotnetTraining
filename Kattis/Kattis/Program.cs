using System.Diagnostics;
using System.IO;
using static System.Console;
using static System.Int32;

namespace Kattis
{
    internal static class Program
    {
        private static int _x, _y, _n;

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            var reader = new StreamReader("input.txt");
            Stopwatch sw = Stopwatch.StartNew();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] split = line.Split(' ');
                //int[] lineInts = Array.ConvertAll(split, s => int.Parse(s));
                //  1 ≤ X < Y ≤ N ≤ 100

                _x = Parse(split[0]);
                _y = Parse(split[1]);
                _n = Parse(split[2]); //  1 to N

                // _x = lineInts[0];
                // y = lineInts[1];
                // n = lineInts[2];

                for (int i = 1; i <= _n; i++)
                {
                    string ans = (i % _x == 0 && i % _y == 0) ? "FizzBuzz"
                          : (i % _y == 0) ? "Buzz"
                          : (i % _x == 0) ? "Fizz"
                          : i.ToString();

                    WriteLine(ans);
                }
                WriteLine(sw.ElapsedTicks + "ms");
                WriteLine("_____________");
            }

            //if (n <= 100 == true)

            //    for (int i = 1; i <= n; i++)
            //    {
            //        WriteLine(ans(i, _x, y));
            //    }

            //else
            //    Write("N does not represent 1 <= 100 ");
            //    Environment.Exit(0);
        }

        /// <summary>
        /// 600% Slower
        /// Returns:
        /// "Fizz" if the number is divisible by _x,
        /// "Buzz" if the number is divisible by y,
        /// "FizzBuzz" if the number is divisible by both _x and y,
        /// the number if it's not divisible by either _x or y
        /// </summary>
        /// <param name="number">the integer to get output for</param>
        /// <returns>a string with the proper output as described in the summary</returns>

        //public static string Ans(int number, int _x, int y)
        //{
        //    if ((number % _x == 0) && (number % y == 0))
        //        return "FizzBuzz";

        //    if (number % _x == 0)
        //        return "Fizz";

        //    if (number % y == 0)
        //        return "Buzz";

        //        return number.ToString();

        //}
    }
}