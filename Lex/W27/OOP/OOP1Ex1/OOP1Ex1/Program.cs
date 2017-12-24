using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOP1Ex1
{

    /*1. Create a class to store details of student like 
     * rollno, name, course joined and fee paid so far. 
     * Assume courses are C# and ASP.NET with course fees being 2000 and 3000.

        Provide the a constructor to take rollno, name and course.
        Provide the following methods:

        Payment(amount)
        Print()
        DueAmount property
        TotalFee property
        




        Add a static member to store Service Tax, which is set to 12.3%. 
        Also allow a property through which we can set and get service tax.
        Modify TotalFee and DueAmount properties to consider service tax.

         */



    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "[Name]", "asp.net");
            s.Payment(1000);
            s.Print();
            Console.WriteLine("Due amount: "+s.DueAmount);
            Console.ReadKey();
        }
    }

    class Student
    {
        private int rollno;
        private string name;
        private string course;
        private double feePaid;
        private static double servicetax = 12.3;

        //private static double total = 0;



        public Student(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
            

        }

        public void Payment(double amount)
        {
            feePaid += amount;

        }
        public void Print()
        {
            Console.WriteLine($"{rollno}\n{name}\n{course}\n{feePaid}");
        }



        //    public double TotalFee
        //    {

        //                get
        //        {
        //            double total = course == "c#" ? 2000 : 3000;// c# 2k other 3k
        //            total = total + ((total * servicetax) / 100);


        //            return TotalFee;
        //        }



        //}


        public double TotalFee
        {

            get => course == "c#" ? 2000 : 3000;
            //get => course == "c#" ? 2000 : 3000;
            //set => TotalFee = TotalFee + ((TotalFee * servicetax) / 100);
        }

        public double TotalFee
        {
            
        }




        public double ServiceTax { get => servicetax; set => servicetax = value; }

        public double DueAmount
        {
            get => TotalFee - feePaid;
            set => DueAmount = value;
        }


    }

}
