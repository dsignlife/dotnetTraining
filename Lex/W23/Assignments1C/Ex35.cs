using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex35
    {
        /*
         Ask the user for a number. Use the number to generate an array with the length of the number. 
         Loop through the array and generate a random number on each position. Tip: Use the Random-class.
             */

        public Ex35(){

            Console.WriteLine("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());

            int[] intArray = new int[input];
            int random = 0;
                 Random r = new Random();
            foreach (var item in intArray)
            {
    
                random = r.Next();
                Console.WriteLine(random);
            }






            }
    }
}
