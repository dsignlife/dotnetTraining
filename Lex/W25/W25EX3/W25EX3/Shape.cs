namespace W25EX3
{
    using System;


    internal abstract class Shape
    {
      public virtual int Height { get; set; }
      public virtual int Width { get; set; }

      public abstract double CalulateSurface(int width, int height);




    }



    internal class Triangle : Shape
    {
        public override double CalulateSurface(int width, int height)
        {
            return(height * width / 2);
        }
    }


    internal class Rectangle : Shape
    {

 
        public override double CalulateSurface(int width, int height)
        {
            return height * width;
        }


    }


    internal class Circle : Shape
    {
        private double radius;


        public override double CalulateSurface(int width, int height)
        {
            radius = (double) (height * width) * Math.PI;
            if (height == width)
            {
                radius = (double) (height * width) * Math.PI;
                return radius;
            }

            else
            {
                return 0;
            }
        }
    }
}