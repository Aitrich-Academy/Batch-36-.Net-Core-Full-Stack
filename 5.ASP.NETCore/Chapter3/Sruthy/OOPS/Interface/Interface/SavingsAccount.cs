using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal class SavingsAccount:IAccount,IReport
    {
        private double balance;
        public SavingsAccount(double initBalance)
        {
            balance = initBalance; 
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposited : " + amount + "\n A/c Balance : "+balance);


        }


        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("\nWithdrawn : " + amount + "\n A/c Balance is : " + balance);
            }
            else
            {
                Console.WriteLine("Insuficient Balance!!!");
            }

        }

        public void GenerateReport()
        {
            Console.WriteLine("\n\n---------------Report-----------------------\n\n");
            Console.WriteLine("Current Balance : " + balance + "\n\n");
            


        }

    }
}
