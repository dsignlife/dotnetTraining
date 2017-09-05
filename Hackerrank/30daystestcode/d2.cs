using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30daystestcode
{
    class d2
    {
  

        public d2()
        {

            

            double mealcost = Convert.ToDouble(input()[0], CultureInfo.InvariantCulture);
            int tippercent = Int32.Parse(input()[1]);
            int taxpercent = Int32.Parse(input()[2]);

            //cal
            double tip = mealcost * tippercent / 100;
            double tax = mealcost * taxpercent / 100;

            //end
            int sum = Convert.ToInt32(mealcost + tip + tax);



            Console.WriteLine("The total meal cost is " + sum + " dollars.");

        }
        static string[] input()
        {

            string[] input = { "12.00", "20", "8" };


            return input;
        }
    }
}
