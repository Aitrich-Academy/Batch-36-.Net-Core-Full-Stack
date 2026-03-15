using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_5_Encapsulation
{
    internal class BankAccount
    {
        // Property with private set
        public double Balance { get; private set; }

        // Constructor
        public BankAccount(double initialBalance)
        {
            if (initialBalance >= 0)
                Balance = initialBalance;
            else
                Balance = 0;
        }

        // Deposit method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Amount Deposited: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Withdraw method
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Amount Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance. Overdraft not allowed.");
            }
        }
    }
}
