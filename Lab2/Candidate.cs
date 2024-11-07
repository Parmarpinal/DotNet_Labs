using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Candidate
    {
        int ID;
        String Name;
        int Age;
        decimal Weight;
        decimal Height;

        public void getCandidateDetails()
        {
            Console.WriteLine("Enter ID :");
            this.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name :");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter age :");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight :");
            this.Weight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter height :");
            this.Height = Convert.ToDecimal(Console.ReadLine());
        }

        public void displayCandidateDetails()
        {
            Console.WriteLine("Candidate ID  = "+this.ID);
            Console.WriteLine("Candidate name  = " + this.Name);
            Console.WriteLine("Candidate age  = " + this.Age);
            Console.WriteLine("Candidate weight = " + this.Weight);
            Console.WriteLine("Candidate height  = " + this.Height);
        }
    }
}
