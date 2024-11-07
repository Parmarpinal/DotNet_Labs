using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Problem5
    {
        public void useOfStringMethods()
        {
            String s = "Darshan University, Rajkot.";
            Console.WriteLine("Actual string = "+s);
            Console.WriteLine("Length = "+s.Length);
            Console.WriteLine("replace = " + s.Replace('a','p'));
            Console.WriteLine("replace line endings = " + s.ReplaceLineEndings());
            Console.WriteLine("starts with d = " + s.StartsWith('d'));
            Console.WriteLine("substring = " +s.Substring(8));
            Console.WriteLine("substring = " + s.Substring(8,5));
            Console.WriteLine("Lowercase = "+s.ToLower());
            Console.WriteLine("Uppercase = "+s.ToUpper());
            String[] arr = s.Split(" ");
            Console.WriteLine("Split = ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);   
            }
        }
    }
}
