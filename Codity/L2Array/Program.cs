using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = {9,3,9,3,9,7,9 };
            Console.WriteLine(solution(input));
            
        }

        public static int solution(int[] A)
        {

           // Array.Sort(A);
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                count = count ^ A[i];
                 
            }



            return count;
        }


    }
}
