using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicEx6
{
    /// <summary>
    /// Class Program.
    /// Declare an array of 10 elements. 
    /// Read values from user and insert them into array. 
    /// Display how many values in the array are positive, negative and zeros
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayoStrings = new string[10];

          

            int counter = 0;

            int pos = 0;
            int neg = 0;
            int zero = 0;

            while (counter < 10)
            {
               
                Console.WriteLine("Enter values: ");

                arrayoStrings[counter] = Console.ReadLine();
                counter++;
            }

           int[] intarray = arrayoStrings.Select(n => Convert.ToInt32(n)).ToArray();

            foreach (var arrayo in intarray)
            {
                if (arrayo < 0)
                
                    neg++;
                
                else if (arrayo > 0)
                    pos++;
                else
                    zero++;
            }


            Console.WriteLine($"{neg} Neg numbers\n{pos} Pos numbers\n{zero} Zero numbers");

            Console.ReadKey();





        }
    }
}
