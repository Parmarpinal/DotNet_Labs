using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Furniture
    {
        public String material;
        public double price;
    }
    class Table:Furniture
    {
        double height, surfaceArea;
        public Table()
        {
            Console.WriteLine("Enter material :");
            material = Console.ReadLine();
            Console.WriteLine("Enter price :");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height :");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter surface area :");
            surfaceArea = Convert.ToDouble(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Furniture material = "+material);
            Console.WriteLine("price = "+price);
            Console.WriteLine("height = "+height);
            Console.WriteLine("surface area = "+surfaceArea);
        }
    }
}
