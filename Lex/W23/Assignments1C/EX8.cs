using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex8
    {
        public Ex8()
        {
            //Below is a given string. Extract the [1,2,3,4,5] from the string into a new string. Then remove the values
            //2 and 3 and insert 6 - 10 into it in the end, comma separated.Display the result.

            String str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";

           int test = str.IndexOf("[");
           Console.WriteLine(test);
           string textIWant = str.Substring(test);

            textIWant = textIWant.Remove(0,1);
            Console.Write(textIWant.Remove(textIWant.Length - 1, 1));

            //string[] arr_temp = Console.ReadLine().Split(',');
           //Array.ConvertAll(arr_temp, Int32.Parse);

        
            


            /*if (textIWant.Contains("2") && textIWant.Contains("3"))
            {
                textIWant.Remove(test);
                Console.WriteLine(test);
       
            }
            //Console.WriteLine(str.Substring(0, test) + textIWant);

            //Console.WriteLine(str.IndexOf("["));
            //String extract = str.Substring();

    */



        }
    }
}
