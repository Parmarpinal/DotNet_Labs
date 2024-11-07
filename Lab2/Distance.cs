using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Distance
    {
        int d1, d2, d3;
        public Distance() {
            Console.WriteLine("Enter two distances :");
            d1 = Convert.ToInt32(Console.ReadLine());
            d2 = Convert.ToInt32(Console.ReadLine());
        }

        public void add()
        {
            this.d3 = d1 + d2;
            Console.WriteLine("Addition = " + this.d3);
        }
    }
}
