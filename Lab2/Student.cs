using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student
    {
        String enrollmentNo, name;
        int semester;
        double cpi, spi;

        public Student()
        {
            Console.WriteLine("Enter enrollment number :");
            this.enrollmentNo = Console.ReadLine();
            Console.WriteLine("Enter name :");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter sem :");
            this.semester = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter cpi :");
            this.cpi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter spi :");
            this.spi = Convert.ToDouble(Console.ReadLine());
        }

        public void displayStudentDetails()
        {
            Console.WriteLine("================= Student information ===============");
            Console.WriteLine("Enrollment no.  = " + this.enrollmentNo);
            Console.WriteLine("name  = " + this.name);
            Console.WriteLine("sem = " + this.semester);
            Console.WriteLine("cpi = " + this.cpi);
            Console.WriteLine("spi  = " + this.spi);
        }
    }
}
