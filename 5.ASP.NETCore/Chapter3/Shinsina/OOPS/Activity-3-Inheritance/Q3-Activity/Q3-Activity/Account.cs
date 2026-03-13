using System;
using System.Collections.Generic;
using System.Text;

namespace Q3_Activity
{
    public class Account
    {
        public string accountNumber;
        public double balance;
        public Account() { }
        public void deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Amount deposited successfully");
        }

        public void displayBalance()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine();
        }
    }
}
