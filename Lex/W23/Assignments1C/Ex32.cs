using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex32
    {
        /*Implement a console application with a menu system. The menu should contain the four options: 
         * 1. Add two numbers together, 
         * 2: Repeat a string x times, 
         * 3: Convert a string to uppercase and 
         * 4: Exit the application. 
         * The menu should reside inside a while-loop that repeats each time a menu choice has been completed, hence allowing the user to choose another options.
         * The only exception is the 4th choice that will terminate the loop. 
         * Each option should call a method that executes the code for the given option. After each respective method call, the console should clear to avoid cluttering the screen.*/

        public Ex32(){


            Console.WriteLine("1. Add two numbers together\n2: Repeat a string x times\n3: Convert a string to uppercase\n4: Exit the application.");
           
         
         int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

       

                switch (input)
                {


                    case 1:
                        Console.WriteLine("Add two numbers together");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a+b);
                    break;
                    case 2:
                        Console.WriteLine("Repeat a string x times");
                    Console.WriteLine("Enter a string: ");
                    string word = Console.ReadLine();
                    //write more
                    
                        break;
                    case 3:
                        Console.WriteLine("Enter a string to convert to uppercase: ");
                        string up = Console.ReadLine().ToUpper();
                        Console.WriteLine(up);
                        break;
                    case 4:
                        Console.WriteLine("Terminate");
                        Environment.Exit(0);
                        break;
                default:

                    Console.WriteLine("Terminate");
                    Environment.Exit(0);

                    break;

                }
            


        }
    }
}
