using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Problem3
    {
        public void stackOperations()
        {
            Stack s1 = new Stack();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            s1.Push(4);
            s1.Push(5);
            s1.Push(6);
            Console.WriteLine("peeked = "+s1.Peek());
            s1.Pop();
            Console.WriteLine("peeked = " + s1.Peek());
            Console.WriteLine("Is 1 exist? => "+s1.Contains(1));
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
