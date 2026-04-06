using System;

namespace BankingSystem
{
    class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        private const decimal MinimumBalance = 100;

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

            if (Balance - amount < MinimumBalance)
                throw new InsufficientBalanceException("Minimum balance ₹1000 required.");

            Balance -= amount;
            Console.WriteLine("Withdrawal successful.");
        }
    }
}