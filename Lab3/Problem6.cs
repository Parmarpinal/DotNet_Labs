using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Problem6
    {
        public void lowerUpper()
        {
            Console.WriteLine("Enter string :");
            String s=Console.ReadLine();
            String ans = "";
            String ch;
            foreach (var item in s)
            {
                if(item >= 'A' && item <= 'Z')
                {
                    ch = item.ToString().ToLower();
                    ans += ch;
                }else if(item >= 'a' && item <= 'z')
                {
                    ch = item.ToString().ToUpper();
                    ans += ch;
                }
                else
                {
                    ans += item;
                }
            }

            Console.WriteLine("Revert of string = "+ans);
        }
    }
}
