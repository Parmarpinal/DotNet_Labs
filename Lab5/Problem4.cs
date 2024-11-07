using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Problem4
    {
        public void queueOperations()
        {
            Queue q1 = new Queue();
            q1.Enqueue(1);
            q1.Enqueue(2);  
            q1.Enqueue(3);
            q1.Enqueue(4);
            q1.Enqueue(5);
            q1.Enqueue(6);
            Console.WriteLine("First element = "+q1.Peek());
            q1.Dequeue();
            Console.WriteLine("First element = "+q1.Peek());
            Console.WriteLine("Is 3 exists? => "+q1.Contains(3));
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
