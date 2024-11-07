using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Bank_Account
    {
        int account_no;
        String email, username, account_type;
        double balance;

        public void getAccountDetails()
        {
            Console.WriteLine("Enter account no. :");
            this.account_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter email :");
            this.email = Console.ReadLine();
            Console.WriteLine("Enter username :");
            this.username = Console.ReadLine();
            Console.WriteLine("Enter account type :");
            this.account_type =Console.ReadLine();
            Console.WriteLine("Enter balance :");
            this.balance = Convert.ToDouble(Console.ReadLine());
        }
        public void displayAccountDetails()
        {
            Console.WriteLine("Account no.  = " + this.account_no);
            Console.WriteLine("email  = " + this.email);
            Console.WriteLine("username  = " + this.username);
            Console.WriteLine("account type = " + this.account_type);
            Console.WriteLine("balance  = " + this.balance);
        }
    }
}
