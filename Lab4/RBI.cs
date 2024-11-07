using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class RBI
    {
        public void calculateInterest(double p,double r,double n)
        {
            Console.WriteLine("RBI Interest = " + (p * r * n)/100);
        }

    }

    class HDFC:RBI
    {
        public void calculateInterest(double p, double r, double n)
        {
            Console.WriteLine("HDFC Interest = " + (p * r * n) / 100);
        }
    }
    class SBI : RBI
    {
        public void calculateInterest(double p, double r, double n)
        {
            Console.WriteLine("SBI Interest = " + (p * r * n) / 100);
        }
    }
    class ICICI : RBI
    {
        public void calculateInterest(double p, double r, double n)
        {
            Console.WriteLine("ICICI Interest = " + (p * r * n) / 100);
        }
    }
}
