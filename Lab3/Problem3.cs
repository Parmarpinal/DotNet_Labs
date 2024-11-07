using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class Sum
    {
        public abstract void sumOfTwo(int x, int y);
        public abstract void sumOfThree(int x, int y, int z);
    }

    class Calculate:Sum
    {
        public override void sumOfTwo(int a, int b)
        {
            Console.WriteLine("Sum of two = "+(a+b));
        }
        public override void sumOfThree(int x, int y, int z)
        {
            Console.WriteLine("Sum of three = "+(x+y+z));
        }
    }
}
