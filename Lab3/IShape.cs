using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface IShape
    {
        void circle(double r);
        void triangle(double r ,double s);
        void square(double a);
    }

    class ShapeDemo:IShape
    {
        public void circle(double r)
        {
            Console.WriteLine("Area of circle = " + (3.14 * r * r));
        }
        public void triangle(double r ,double s)
        {
            Console.WriteLine("Area of triangle = " + ((r * s) / 2));
        }
        public void square(double a)
        {
            Console.WriteLine("Area of square = " + (a * a));
        }
    }
}
