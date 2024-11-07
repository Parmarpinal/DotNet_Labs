using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class BankAccount
    {
        public string AccountHolderName;
        public decimal Balance;

        public BankAccount(decimal initialBalance, string accountHolderName)
        {
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        // Method to deposit cash
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Deposited cash: {amount}. New balance: {Balance}");
        }

        // Overloaded method to deposit by check
        public void Deposit(decimal amount, string checkNumber)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Deposited check: {amount} (Check No: {checkNumber}). New balance: {Balance}");
        }

        // Method to withdraw cash
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Withdrew cash: {amount}. New balance: {Balance}");
        }

        // Overloaded method to withdraw using check
        public void Withdraw(decimal amount, string checkNumber)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Withdrew by check: {amount} (Check No: {checkNumber}). New balance: {Balance}");
        }
    }
}
