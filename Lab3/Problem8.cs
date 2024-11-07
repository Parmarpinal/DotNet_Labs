using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Problem8
    {
        public void notEvenNumber()
        {
            try
            {
                Console.WriteLine("Enter number :");
                int n = Convert.ToInt16(Console.ReadLine());
                if (n % 2 != 0)
                {
                    throw new Exception("================ Not even number ==============");
                }
                Console.WriteLine(n);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
