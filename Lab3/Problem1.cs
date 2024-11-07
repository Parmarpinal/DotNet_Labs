using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Problem1
    {
        public void zeroDivision()
        {
            try
            {
                Console.WriteLine("Enter numerator :");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter denomerator :");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Division = " + a / b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
