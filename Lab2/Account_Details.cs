using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lab2
{
    class Account_Details
    {
        protected double amount,rate, duration;

        public void getAccountDetails() {
            Console.WriteLine("Enter amount :");
            amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate :");
            rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter duration :");
            duration = Convert.ToDouble(Console.ReadLine());
        }
    }
    class Interest : Account_Details {
        public Interest()
        {
            getAccountDetails();
        }
        public void displayInterest()
        {
            Console.WriteLine("Interest = " + (amount*rate*duration)/100);
        }
    }
}
