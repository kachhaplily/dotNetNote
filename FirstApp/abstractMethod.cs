using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public abstract class abstractMethod
    
    {
        public double height, width, radius;
        public const float pi = 3.14f;

        public abstract double getArea();
    }

    public class reactange : abstractMethod
    {
        public reactange(double height, double width)
        {
            this.height = height;
            this.width = width;

        }

        public override double getArea()
        {
            return height * width;

        }
    }

    public class circle : abstractMethod
    {
        public circle(double radius)
        {

            this.radius = radius;
        }
        public override double getArea()
        {
            return 2 / pi * radius;
        }
    }

    public class cone : abstractMethod
    {
        public cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;

        }

        public override double getArea()
        {
            return pi * radius * (radius + Math.Sqrt(height * height + radius * radius));
        }
    }

    public class result
    {
        static void Main(string[] args)
        {
            reactange r = new reactange(23.444D, 545.5446D);
            circle c = new circle(4);
            cone ce = new cone(2, 20);

            Console.WriteLine(r.getArea());
            Console.WriteLine(c.getArea());
            Console.WriteLine(ce.getArea());
            Console.ReadLine();
        }
    }
}
