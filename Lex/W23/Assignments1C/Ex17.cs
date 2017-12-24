using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex17
    {
        /*Write a program that lets a user enter two numbers: a and b. Convert them into integers. 
         * Then show the result from a + b, a – b, a * b and a / b to the user with a descriptive label. 
         * Make a check before dividing that b is not zero, if so display a message that it cannot be divided. 
         * Make sure to cast one of the integers to a double number.*/
         public Ex17()
        {
            Console.WriteLine("Enter numbers (x y): ");

            string[] arr_temp = Console.ReadLine().Split(' ');
            //Array.ConvertAll(arr_temp, Int32.Parse);
            double[] arrint = arr_temp.Select(double.Parse).ToArray();
            //  Console.WriteLine(result);
            // int result = Convert.ToInt32(arr_temp[0]) + Convert.ToInt32(arr_temp[i + arr_temp.Length]);
            Plus(arrint);
            Minus(arrint);
            Mul(arrint);
            Div(arrint);



        }

        public void Plus(double []arrint)
        {
            double result = arrint[0] + arrint[1];
            Console.WriteLine(result);
        }
        public void Minus(double[]arrint)
        {
            double result = arrint[0] - arrint[1];
            Console.WriteLine(result);
        }
        public void Mul(double[] arrint)
        {
            double result = arrint[0] * arrint[1];
            Console.WriteLine(result);
        }
        public void Div(double[] arrint)
        {
            double result = arrint[0] / arrint[1];
            Console.WriteLine(result);
        }
    }
}
