using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex39
    {
        /*
         Create two arrays with equal sizes. One should contain username and one should contain passwords.

            
         Let the user try to input a username and a password and match it against the arrays. 
         If he types in a correct username and password, 
         display a secret message to him.
         (You can assume that username on position n belongs to password on position n in respective array)
             */

        public Ex39()
        {

            var firstArray = new string[5];
            var secArray = new string[5];

            int checkUser = 0;
            int checkPass = 0;
 
            firstArray[0] = "aa";
            firstArray[1] = "bb";
            secArray[0] = "11";
            secArray[1] = "22";


            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();

       
            for (int i = 0; i < firstArray.Length; i++)
            {

                if (username == firstArray[i])
                {
                    i = checkUser;
                }
                
                
            }

            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            for(int d = 0; d < secArray.Length; d++)
            {

                if (password == secArray[d])
                {
                    d = checkUser;
                }
     
            }



            if (checkUser == checkPass)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
    }
}
