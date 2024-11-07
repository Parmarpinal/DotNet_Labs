using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface ICalculate
    {
        void addition();
        void subtraction();
    }

    class Result:ICalculate
    {
        public void addition()
        {
            Console.WriteLine("Enter two numbers :");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Addition = "+(a+b));
        }

        public void subtraction()
        {
            Console.WriteLine("Enter two numbers :");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Addition = " + (a - b));
        }
    }
}
