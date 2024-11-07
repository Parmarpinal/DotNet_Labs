using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Salary1
    {
        double basic, da, hra, ta;
        public Salary1() {
            da = 5000;
            hra = 7000;
            Console.WriteLine("Enter basic salary:");
            basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter ta :");
            ta = Convert.ToDouble(Console.ReadLine());
        }
        public void displaySalary()
        {
            Console.WriteLine("Gross salary = " + (basic + da + hra + ta));
        }
    }
}
