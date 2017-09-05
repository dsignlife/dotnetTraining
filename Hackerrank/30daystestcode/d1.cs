using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _30daystestcode
{
    class d1
    {
       


        public static string[] input()
        {

            string[] input = { "12", "4.0", "is the best place to learn and practice coding!" };

            return input;
        }


        public d1()
        {
            string[] stdin = input();

            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.


            int inputInt;
            double inputDouble;
            string inputString;

            // Read and save an integer, double, and String to your variables.


            inputInt = Convert.ToInt32(stdin[0]);
            inputDouble = Double.Parse(stdin[1], CultureInfo.InvariantCulture);
            inputString = stdin[2];



            //Convertion




            // Print the sum of both integer variables on a new line.

            WriteLine(i + inputInt);

            // Print the sum of the double variables on a new line.

            WriteLine("{0:0.0}", d + inputDouble);

            // Concatenate and print the String variables on a new line
            WriteLine(s + inputString);
            // The 's' variable above should be printed first.


        }



    }

}
