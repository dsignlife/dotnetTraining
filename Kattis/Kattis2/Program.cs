using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var maximal = 4711;
            while (true)
            {
                var input = Convert.ToInt32(Console.ReadLine());

                if (input == 0 || input > maximal)
                    break;

                List<int> list = new List<int> { 0 };

                for (int i = 1; list.Count < input; i++)
                {
                    list.AddRange(Enumerable.Range(1, i));
                }

                Console.WriteLine(list.Last());
            }
        }
    }
}