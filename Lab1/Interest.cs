using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Interest
    {
        double amount, duration, rate;

        public Interest()
        {
            Console.WriteLine("Enter amount :");
            amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter duration :");
            duration = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate :");
            rate = Convert.ToDouble(Console.ReadLine());
        }

        public void calculateInterest()
        {
            double si = amount * duration * rate;
            Console.WriteLine($"Simple interest = {si}");
        }
    }
}
