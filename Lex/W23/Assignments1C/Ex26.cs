using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex26
    {
        /*Write a program that keeps asking the user for input numbers, until he enters -1.. 
         * Store the amount of numbers the user have entered and the sum of the numbers added together. 
         * When the user types -1, the program should display the total and the average.*/

        public Ex26(){

            int input = 0;
            var inputs = new List<int>();

            Console.WriteLine("Input numbers: ");

            while (input != -1)
            {
                   
                input = Convert.ToInt32(Console.ReadLine());

                if (input == -1)
                {
                    Console.WriteLine("Total: " + inputs.Sum() + " Average: " + inputs.Sum() / inputs.Count);
                    break;
                }

                inputs.Add(input);
                

            }

    
        }

    }
}
