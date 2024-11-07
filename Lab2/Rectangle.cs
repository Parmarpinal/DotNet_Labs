using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Rectangle
    {
        double width, height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }
        public void displayArea()
        {
            Console.WriteLine("Area of rectangle = " + (width * height));
        }
    }
}
