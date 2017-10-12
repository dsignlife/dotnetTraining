using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Kattis
{
    class Program
    {

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {


            //string[] line = ReadLine().Split(' ');
            string line = "3 5 7";
            string[] split = line.Split(' ');


            //  1 ≤ X < Y ≤ N ≤ 100  

            int x = Convert.ToInt32(split[0]);
            int y = Convert.ToInt32(split[1]);
            int n = Convert.ToInt32(split[2]); //  1 to N

            //if (n <= 100 == true)


            //    for (int i = 1; i <= n; i++)
            //    {
            //        WriteLine(ans(i, x, y));
            //    }

            //else
            //    Write("N does not represent 1 <= 100 ");
            //    Environment.Exit(0);



            for (int i = 1; i <= n; i++)
            {

                string ans = (i % x == 0 && i % y == 0) ? "FizzBuzz" 
                    : (i % y == 0) ? "Buzz" 
                    : (i % x == 0) ? "Fizz" 
                    : i.ToString();
                WriteLine(ans);
            }






        }



        /// <summary>
        /// Returns:
        /// "Fizz" if the number is divisible by x,
        /// "Buzz" if the number is divisible by y,
        /// "FizzBuzz" if the number is divisible by both x and y,
        /// the number if it's not divisible by either x or y
        /// </summary>
        /// <param name="number">the integer to get output for</param>
        /// <returns>a string with the proper output as described in the summary</returns>

        public static string ans(int number, int x, int y)
        {


            if ((number % x == 0) && (number % y == 0))

                return "FizzBuzz";

            else if (number % x == 0)

                return "Fizz";

            else if (number % y == 0)

                return "Buzz";
            else

                return number.ToString();


        }


    }
}
