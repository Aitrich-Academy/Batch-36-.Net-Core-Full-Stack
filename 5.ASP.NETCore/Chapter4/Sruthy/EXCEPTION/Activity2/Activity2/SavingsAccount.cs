using System;
using System.Collections.Generic;
using System.Text;

namespace Activity2
{
    class SavingsAccount:BankAccount
    {
        double minBal = 1000;
        public double interestRate = 0.08;
        public override void Deposit(double amount)
        {
            if(amount <=0)
            {
                throw new InvalidAmountException("Invalid Amount!!!!");

            }
            Balance = Balance + amount;
            Console.WriteLine("Deposited Successfully");


        }

        public override void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Invalid Amount!!!!");

            if (Balance-amount < minBal)
                throw new InsufficientBalanceException("You should keep the minimum Balance in your account!!! ");

            Balance = Balance - amount;
            Console.WriteLine("Amount Withdrawed Successfully");

        }

    }
}
