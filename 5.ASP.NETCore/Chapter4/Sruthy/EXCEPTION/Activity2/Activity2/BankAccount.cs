using System;
using System.Collections.Generic;
using System.Text;

namespace Activity2
{
    abstract class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        private double balance;

        public double Balance { get { return balance; } set { balance = value; }  }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);

        public void DisplayAccountDetails()
        {
            Console.WriteLine("--------------------------Account Details----------------------");
            Console.WriteLine("Account Holder: " + AccountHolderName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Balance: " + Balance);
        }



    }
}
