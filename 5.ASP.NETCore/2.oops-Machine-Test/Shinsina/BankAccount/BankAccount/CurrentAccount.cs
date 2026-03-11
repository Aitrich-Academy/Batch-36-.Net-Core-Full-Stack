using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    internal class CurrentAccount:Account
    {
        public CurrentAccount(string accountHolder, decimal balance) : base(accountHolder, balance) { }

        public override void CalculateInterest()
        {
            Console.WriteLine("current account having no interest");
        }
    }
}
