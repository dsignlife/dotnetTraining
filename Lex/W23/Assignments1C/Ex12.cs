using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1C
{
    class Ex12
    {
        /*Write a program that lets a user enter a name. Check if that name is either Bob or Alice. If it is, display “Hi Bob” or “Hi Alice”.*/
        public Ex12() {

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();

            if (string.Equals(name, "alice", StringComparison.OrdinalIgnoreCase)) {

                Console.WriteLine("Hi Alice");
                
            }

            else 
            
            if (string.Equals(name, "bob", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hi Bob");
            }

            else
            {
                Console.WriteLine("Welcome "+name);
            }
               
        }

        
      
    }
}
