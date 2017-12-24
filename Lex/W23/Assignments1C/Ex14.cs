using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex14
    {
        //Write a program that lets a user type in some text. Then check whether the word “city” occurs in the
        //string and display a message to the user at what position.Tip: IndexOf
        public Ex14()
        {
            Console.WriteLine("Write in some texts: ");
            string[] arr_temp = Console.ReadLine().Split(' ');

            for (int d = 0; d < arr_temp.Length; d++)


            {

            if (arr_temp[d].Contains("city"))
            {
                    Console.WriteLine("The Position of city in the Array is "+ (d+1));
            }

     
            }
        }

    }
}
