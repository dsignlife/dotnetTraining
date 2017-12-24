using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex16
    {
        /*Write a program that displays 3 different options that the user can choose from. 
         * Depending on the choice, display a different message. If the choice is not valid, display a message.
         * Use the Console.Clear-method to remove the options after the choice.*/

        public Ex16()
        {

            Console.WriteLine("Enter 1-3: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

 

            
            switch (input)
            {


                case 1:
                    Console.WriteLine("Abo 1");
                    break;
                case 2:
                    Console.WriteLine("Abo 2");
                    break;
                case 3:
                    Console.WriteLine("Abo 3");
                    break;
                default:
                    Console.WriteLine("default");
                    Environment.Exit(0);
                    break;
            }
            

        }


    }
}
