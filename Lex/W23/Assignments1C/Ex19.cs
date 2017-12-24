using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex19
    {
        /*Write a program that lets the user input a colour. Then use a switch statement to check if the colour exists.
         * If it doesn’t display an error message. Then, print out the name of the colour with the same colours. Tip: use Console.ForegroundColor to change the color of the text.*/


      //  string[] arr_temp = Console.ReadLine().Split(' ');

        public Ex19()
        {

            Console.WriteLine("Enter a color: ");
            string input = Console.ReadLine();
            Console.Clear();

            switch (input.ToLower())
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(input);
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(input);
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(input);
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(input);
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(input);
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(input);
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(input);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(input);
                    break;

            }
        }


    }
}
