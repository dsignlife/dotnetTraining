using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex11
    {
        /*Let the user input a decimal number. Then output square root of the number and the number raised to the power of 2, 3 and 10. That is √𝑛 ,𝑛2,𝑛3,𝑛10.*/
        public Ex11()
        {
            Console.WriteLine("In put a decimal number: ");
            double input = Convert.ToDouble(Console.ReadLine());
            Calulate(input);
        }

        public void Calulate(double a)
        {
            Console.WriteLine("Sqrt: "+Math.Sqrt(a) + " Pow2: "+ Math.Pow(a, 2) + " Pow 3: "+ Math.Pow(a, 3) + " Pow 10: " + Math.Pow(a, 10));
        }
    }
}
