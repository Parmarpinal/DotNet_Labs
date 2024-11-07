using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface Gross
    {
        double grossSalary();
    }
    class Employee
    {
        public String name;
        public double basicSal;

        public void basicSalary()
        {
            Console.WriteLine("Enter name :");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter basic salary :");
            this.basicSal = Convert.ToDouble(Console.ReadLine());
        }
    }
    class Salary:Employee, Gross
    {
        double HRA, TA, DA;
        public Salary()
        {
            basicSalary();
            Console.WriteLine("Enter HRA = ");
            HRA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter TA = ");
            TA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter DA = ");
            DA = Convert.ToDouble(Console.ReadLine());
        }
        public double grossSalary()
        {
            return basicSal+HRA+TA+DA;
        }
        public void displaySalary()
        {
            Console.WriteLine("Name : {0}, Salary : {1}",name,grossSalary());
        }
    }
}
