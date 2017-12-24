using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W25EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human a = new Human();
            Console.WriteLine("Enter FirstName: ");
            a.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName: ");
            a.LastName = Console.ReadLine();


            Console.WriteLine($"Welcome {a.FirstName}, are you W or S?");


            
            string input = Console.ReadLine().ToUpper();
   
            
            switch (input)
            {
                case "W":
                    Worker w = new Worker();
                    Console.WriteLine("Enter WeekSalary : ");
                    w.WeekSalary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter HourPerDay : ");
                    w.HourPerDay = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Name: {a.FirstName} /nMoney per hour: {w.MoneyPerHour()} ");
                    
                break;
                case "S":

                    break;

                default:
                    Console.WriteLine("Noob");
                    break;

            }

            













            Student s = new Student();

            s.StudentArray[0] = "Abo0";
            s.StudentArray[1] =  "Abo1";
            s.StudentArray[2] = "Abo2";
            s.StudentArray[3] = "Abo3";

//            s.Grade[0] = 'B';
  //          s.Grade[1] = 'D';
    //        s.Grade[2] = 'C';
      //      s.Grade[3] = 'A';
      
            Console.WriteLine();





  

        


            Console.Read();
        }
    }
}
