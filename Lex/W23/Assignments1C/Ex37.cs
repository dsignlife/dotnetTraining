using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex37
    {
        /*
         Create two arrays with arbitrary sizes and fill them with random numbers. Then make a new array with the combined size of the two previous arrays and copy the values into it.
             */

        public Ex37(){


            var arrayOne = new List<int>();
            var arrayTwo = new List<int>();

            Console.WriteLine("Enter total numbers to generate:");
            int input = Convert.ToInt32(Console.ReadLine());

            int random = 0;
            Random r = new Random();

            for (int i = 0; i < input; i++)
            {
                random = r.Next();
                arrayOne.Add(random);
                Console.WriteLine(random);

            }
            Console.WriteLine("Enter total numbers to generate again:");
            int input2 = Convert.ToInt32(Console.ReadLine());

            for (int d = 0; d < input2; d++)
            {
                random = r.Next();
                arrayTwo.Add(random);
                Console.WriteLine(random);
            }



            //int[] intArray = dlist.Select(temp => Convert.ToInt32(temp)).ToArray();

            int[] intArray = new int[arrayOne.Count+arrayTwo.Count];



            int counter = 0;
            foreach (var item in arrayOne)
            {
                intArray[counter] = arrayOne[counter];
                Console.WriteLine(intArray[counter] + " Array");
                counter++;
            }
            int counter2 = 0;
            foreach (var item in arrayTwo)
            {
                intArray[counter] = arrayTwo[counter2];
                Console.WriteLine(intArray[counter] + " Array");
                counter++;
                counter2++;
            }

        }
    }
}
