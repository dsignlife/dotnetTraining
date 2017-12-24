using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment2C
{
    class Ex1
    {

        /*
         * 
         * Creating a class
         Create a class that represents a person. Let the class hold information about the person first name, last name and age. 
         Let the constructor take in above data as parameters and create get-only functionality.
         Write a method in the Program class that takes the person-datatype as a parameter and print out the information about that person. 
         Create a few person objects and pass into the function.

             */
        public Ex1()
        {
            var o = new Person();
            o.takeInDataEx1("abo", "nqyuui", 11);






        }





    }

    public class Person
    {
       
        public Person()
        {
            Firstname = "helo";
            Lastname = "boa";
            Age = 10;
        }
        public string Firstname { get; }
        public string Lastname { get;  }
        public int Age { get; }

        public void takeInDataEx1(string a, string b, int c)
        {
            WriteLine($"info : {a} {b} {c} ");
        }

        public void Speak()
        {
            
            WriteLine($"Hello my name is {Firstname} {Lastname}");
        }
    }
}
