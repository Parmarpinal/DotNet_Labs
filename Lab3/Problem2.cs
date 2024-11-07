using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Problem2
    {
        public void indexOutOfRange()
        {
            try
            {
                int[] a = new int[5];
                Console.WriteLine("Enter elements :");
                int i = 0;
                while (true)
                {
                    a[i] = Convert.ToInt16(Console.ReadLine());
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
