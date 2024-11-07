using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Calculator
    {
        double a, b;
        public Calculator() {
            Console.WriteLine("Enter two numbers :");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
        }

        public void perform()
        {
            Console.WriteLine("Which operation do you want to perform (+,-,*,/) ?");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine($"Addition = {a+b}");
                    break;
                case "-":
                    Console.WriteLine($"Subtraction = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"Multiplication = {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"Division = {a / b}");
                    break;
                default:
                    Console.WriteLine("======================== Invalid input =====================");
                    break;
            }
        }

    }
}
