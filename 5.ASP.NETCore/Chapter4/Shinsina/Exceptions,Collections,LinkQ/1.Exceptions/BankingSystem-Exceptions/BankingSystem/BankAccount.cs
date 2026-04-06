using System;

namespace BankingSystem
{
    abstract class BankAccount
    {
        private int accountNumber;
        private string accountHolderName;
        private decimal balance;


        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Holder: " + AccountHolderName);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}