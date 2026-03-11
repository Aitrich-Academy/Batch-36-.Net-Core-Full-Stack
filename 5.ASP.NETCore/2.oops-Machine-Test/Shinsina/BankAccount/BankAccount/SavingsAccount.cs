using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class SavingsAccount:Account
    {
        public SavingsAccount(string accountHolder, decimal balance) : base(accountHolder, balance) { }

        public override void CalculateInterest()
        {
            decimal interest = Balance * 0.05m;
            Balance += interest;
            Console.WriteLine($"Interest added to {AccountHolder}, \nInterest : {interest} \nNew Balance : {Balance }");
        }
    }
}
