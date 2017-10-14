using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using static System.Console;

namespace KnightsinFen
{
    public static class Program
    {
        private static int _testcases;
        private static Stopwatch sw;

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            var reader = new StreamReader("input.txt");
            sw = Stopwatch.StartNew();

            try
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _testcases = int.Parse(line);
                    string[] boards = new string[_testcases * 5];

                    for (int i = 0; i < _testcases * 5; i++)
                    {
                        line = reader.ReadLine();
                        boards[i] = line;
                    }

                    SplitBoard(boards);


                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Splits the board.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns></returns>
        private static void SplitBoard(string[] board)
        {
            int[] result = new int[_testcases];

            for (int i = 0; i < _testcases; i++)
            {
                string[] currentBoard = board.Skip(i * 5).Take(5).ToArray();
                result[i] = Calculation.Solve(currentBoard);
                WriteLine(result[i] <= 10 ? $"Solvable in {result[i]} move(s)." : "Unsolvable in less than 11 move(s).");
                WriteLine(sw.Elapsed + "s");
            }
         
        }
    }
}