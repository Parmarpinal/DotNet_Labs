using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Staff
    {
        String name;
        String department;
        public String designation;
        int experience;
        double salary;

        public void getStaffDetails()
        {
            Console.WriteLine("Enter name :");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter department :");
            this.department = Console.ReadLine();
            Console.WriteLine("Enter designation :");
            this.designation = Console.ReadLine();
            Console.WriteLine("Enter experience :");
            this.experience = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter salary :");
            this.salary = Convert.ToDouble(Console.ReadLine());
        }

        public void displayStaffDetails()
        {
            Console.WriteLine("Staff name = "+this.name);
            Console.WriteLine("salary = " + this.salary);
        }
    }
}
