using System;

namespace W25EX3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            Shape a1 = new Triangle();
            Shape a2 = new Rectangle();
            Shape a3 = new Circle();

            a1.Height = 5;
            a1.Width = 3;

            Console.WriteLine("Triangle: " + a1.CalulateSurface(a1.Height, a1.Width));

            a2.Height = 7;
            a2.Width = 5;

            Console.WriteLine("Rectangle: " + a2.CalulateSurface(a2.Height, a2.Width));


            a3.Height = 3;
            a3.Width = 3;

            Console.WriteLine("Circle: " + a3.CalulateSurface(a3.Width, a3.Height));

            Console.ReadKey();
        }
    }
}