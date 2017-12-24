using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex34
    {
        /*
         Loop through the arrays from the previous exercise and print the content to the console window. For the names, write every second name with upper case.
             */

        public Ex34(){


            var stringArray = new List<string>();
            var intArray = new List<int>();

            intArray.Add(1);
            intArray.Add(2);
            stringArray.Add("abo1");
            stringArray.Add("abo2");
            stringArray.Add("abo3");
            stringArray.Add("abo4");


            for (int i = 0; i < stringArray.Count; i+=2)
            {
                Console.WriteLine(stringArray[i].ToUpper());
            }


        }
    }
}
