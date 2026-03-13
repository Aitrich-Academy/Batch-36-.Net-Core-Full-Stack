using System;
using System.Collections.Generic;
using System.Text;

namespace Q3_Activity
{
    public class SavingsAccount : Account
    {
        public double interestRate;

        public void addInterest()
        {
            double interest = balance * interestRate / 100;
            balance += interest;
            Console.WriteLine("Interest added: " + interest);
        }
    }
}
