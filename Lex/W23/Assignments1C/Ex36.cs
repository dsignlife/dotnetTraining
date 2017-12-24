using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex36
    {
        /*
         Create an array with arbitrary size and fill with random numbers like the previous exercise. 
         Then create a new array with the same size and copy over the values to it.
             */

        public Ex36(){

            Console.WriteLine("Enter total numbers to generate:");
            int input = Convert.ToInt32(Console.ReadLine());

            int random = 0;
            Random r = new Random();
            var dlist = new List<int>();

            for (int i = 0; i < input; i++)
            {
                random = r.Next();
                dlist.Add(random);
                Console.WriteLine(random);
            }


            


            int[] intArray = dlist.Select(temp => Convert.ToInt32(temp)).ToArray();

            int counter =0;
            foreach (var item in intArray)
            {
                Console.WriteLine(intArray[counter]+ " Array");
                counter++;
            }




        }
    }
}
