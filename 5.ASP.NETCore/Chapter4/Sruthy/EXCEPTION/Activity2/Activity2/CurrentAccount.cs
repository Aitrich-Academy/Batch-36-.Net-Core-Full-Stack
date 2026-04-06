using System;
using System.Collections.Generic;
using System.Text;

namespace Activity2
{
    class CurrentAccount :BankAccount
    {
        public double OverdraftLimit { get; set; }

        public override void Deposit(double amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Invalid Amount");

            Balance = Balance +amount;
            Console.WriteLine("Amount Deposited Successfully");
        }

        public override void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Invalid withdraw amount");

            if (Balance + OverdraftLimit < amount)
                throw new InsufficientBalanceException("Overdraft limit exceeded");

            Balance = Balance - amount;
            Console.WriteLine("Withdrawal Successful");
        }
    }

}

