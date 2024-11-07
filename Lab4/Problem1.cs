using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Problem1
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("Sum = "+(a+b));
        }
        public void sum(float a, float b)
        {
            float ans = a + b;
            Console.WriteLine("Sum = " + ans);
        }
    }
}
