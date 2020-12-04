using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis3
{
    public class Program
    {
        static int BITS = 64;

        public static void Main(string[] args)
        {

            int listLength = Convert.ToInt32(Console.ReadLine());
            var inputList = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();

            var list = new List<List<long>>();

            for (int i = 0; i < BITS; i++)
            {
                list.Add(new List<long>());
            }

            foreach (var item in inputList)
            {
                list[Size(item)].Add(item);
            }

            var check = new List<long>();

            for (int i = BITS - 1; i >= 0; i--)
            {
                if (!list[i].Any())
                    continue;

                var x = list[i][0];

                for (int o = 1; o < list[i].Count(); o++)
                {
                    var y = x ^ list[i][o];
                    if (y > 0)
                        list[Size(y)].Add(y);
                }
                check.Add(x);
            }

            var max = check.Aggregate<long, long>(0, (current, x) => Math.Max(current, current ^ x));
            Console.WriteLine(max);

        }

        public static int Size(long bits)
        {
            return (int)Math.Log(bits, 2) + 1;
        }

    }
}