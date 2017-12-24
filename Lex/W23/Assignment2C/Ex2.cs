using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment2C
{
    class Ex2
    {

        /*
         Adding methods to the class
         Add a method Speak that writes out “Hello my name is {first name} {last name}” to the screen when calling it on a person object.

             */
        public Ex2()
        {
            var a = new Person();
            a.Speak();

        }

        //public void Speak()
        //{
        //    var a = new Person();
        //    WriteLine($"Hello my name is {a.Firstname} {a.Lastname}");
        //}
    }
}
