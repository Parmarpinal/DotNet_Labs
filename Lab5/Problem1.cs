using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Problem1
    {
        public void studentNames()
        {
            ArrayList students = new ArrayList();
            students.Add("ABC");
            students.Add(2);
            students.Add("poiu");
            students.Add(3);
            students.Add("DEF");
            students.Add(4);
            students.RemoveAt(2);
            students.Remove("ABC");
            students.RemoveRange(1, 3);
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
