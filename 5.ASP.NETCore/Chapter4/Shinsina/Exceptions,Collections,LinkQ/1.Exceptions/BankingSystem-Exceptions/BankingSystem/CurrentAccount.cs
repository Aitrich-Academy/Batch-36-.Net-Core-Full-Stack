using System;

namespace BankingSystem
{
    class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Deposit amount must be positive.");

            Balance += amount;
            Console.WriteLine("Deposit successful.");
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Withdrawal amount must be positive.");

            if (Balance + OverdraftLimit < amount)
                throw new InsufficientBalanceException("Overdraft limit exceeded.");

            Balance -= amount;
            Console.WriteLine("Withdrawal successful.");
        }
    }
}