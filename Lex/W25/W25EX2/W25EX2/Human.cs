using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W25EX2
{
    class Human
    {
        private string firstName;
        private string lastName;

       


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }


        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
    }

    class Student : Human
    {
        private char[] grade = new char[10];
        private string[] studentArray = new string[10];

        public char[] Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public string[] StudentArray
        {
            get { return studentArray; }
            set { studentArray = value; }
        }

        


    }

    class Worker : Human
    {
        private int weekSalary;
        private int hourPerDay;

        string[] workerArray = new string[10];



        public string[] WokerArray
        {
            get { return workerArray; }
            set { workerArray = value; }
        }



        public int WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }


        public int HourPerDay
        {
            get { return hourPerDay; }
            set { hourPerDay = value; }
        }



        public double MoneyPerHour(int weekSalary, int HourPerDay)
        {

           return HourPerDay *((weekSalary / 7) /24);
            
        }

        public double MoneyPerHour()
        {

            return (double)HourPerDay * ((weekSalary / 7) / 24);


        }
    }
}
