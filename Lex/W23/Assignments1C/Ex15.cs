using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex15
    {
        public Ex15()
        {
            /*Write a program that lets a user type in some text, then check whether the length of the string is
greater than 25 characters. Display a message to the user.*/

            Console.WriteLine("Write in some texts: ");
            string arr = Console.ReadLine();


            if (arr.Length > 25)

            {
                Console.WriteLine("Greater than 25 chars");
            }
            else
            {
                Console.WriteLine("!greater than 25 chars");
            }


        }
    }
}
