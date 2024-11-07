using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Problem10
    {
        public void changeCase()
        {
            try
            {
                Console.WriteLine("Enter character :");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch >= 'A' && ch <= 'Z')
                {
                    Console.WriteLine(ch.ToString().ToLower());
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    Console.WriteLine(ch.ToString().ToUpper());
                }
                else
                {
                    Console.WriteLine("Not alphabet");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
