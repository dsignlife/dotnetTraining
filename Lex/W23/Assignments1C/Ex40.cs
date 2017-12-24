using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex40
    {
        /*
         Let the user input a string with numbers comma separated like “1,2,34,83,19,45”
         then separate the numbers into an array and find the min, max and average value. 
         Print these out to the screen. Tip: use the Split-function.
             */

        public Ex40()
        {

            Console.WriteLine("Enter a string with numbers using , as a seperator: ");
            string input = Console.ReadLine();
            string[] inputs = input.Split(',');
            int[] nums = new int[inputs.Length];
            int counter =0;
            foreach (string num in inputs)
            {

                nums[counter] = Int32.Parse(inputs[counter]);
                counter++;
            }



            Array.Sort(nums);
            int avg = nums.Sum()/nums.Length;
            int max = nums[0];
            int min =  nums[nums.Length-1];
            Console.WriteLine($"Min = {min} Max = {max} Avg = {avg}");



        }


    }
}
