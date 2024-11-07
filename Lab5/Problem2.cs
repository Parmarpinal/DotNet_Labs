using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Problem2
    {
        public void listGenericOperations()
        {
            List<object> list = new List<object>();
            list.Add(102);
            list.Add("abcd");
            list.Add(true);
            list.Add(103);
            list.Add("defg");
            list.Add(false);
            list.RemoveAt(2);
            list.RemoveRange(2, 3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
