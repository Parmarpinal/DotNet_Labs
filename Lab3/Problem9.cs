using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Problem9
    {
        public void longestString()
        {
            Console.WriteLine("Enter string :");
            String s=Console.ReadLine();
            String[] a = s.Split(" ");
            int max = 0;
            String ans = "";
            foreach (var item in a)
            {
                if(item.Length > max)
                {
                    max = item.Length;
                    ans = item;
                }
            }
            Console.WriteLine("Longest word = "+ans);
        }
    }
}
