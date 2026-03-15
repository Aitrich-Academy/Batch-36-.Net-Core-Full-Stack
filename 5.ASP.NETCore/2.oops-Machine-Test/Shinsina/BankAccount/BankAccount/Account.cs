using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
public abstract class Account
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public Account(string accountHolder, decimal balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public abstract void CalculateInterest();

        public void ApplyMaintenanceFee(decimal fee)
        {
            Balance -= fee;
            Console.WriteLine($"\nMaintenance fee {fee} deducted from {AccountHolder} New Balanace:{Balance}");
        }
    }
}
