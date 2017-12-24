using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex31
    {
        /*Let the user input a string, then check if the string is a palindrome.
         * A palindrome is a word or sentence that reads the same in both directions. 
         * Example Loops at a spool and wet stew. The spaces between might not be the same thought so keep that in mind.*/

        public Ex31(){

            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            char[] word = input.ToCharArray();
            Console.WriteLine(istPalindrom(word));


            }

        public static bool istPalindrom(char[] word)
        {
            int i1 = 0;
            int i2 = word.Length - 1;
            while (i2 > i1)
            {
                if (word[i1] != word[i2])
                {
                    return false;
                }
                ++i1;
                --i2;
            }
            return true;
        }
    }
}
