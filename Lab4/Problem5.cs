using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Problem5
    {
        public void area(int a)
        {
            Console.WriteLine("Area of square = " + (a * a));
        }
        public void area(int a, int b)
        {
            Console.WriteLine("Area of rectangle = " + (a * b));
        }
        public void area(double r)
        {
            Console.WriteLine("Area of circle = "+(Math.PI*r*r));
        }
    }
}
