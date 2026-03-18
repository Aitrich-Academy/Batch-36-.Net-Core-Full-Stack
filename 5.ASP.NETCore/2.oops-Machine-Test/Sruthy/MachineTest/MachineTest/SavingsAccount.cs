using System;
using System.Collections.Generic;
using System.Text;

namespace MachineTest
{
    class SavingsAccount : Account
    {
        public double monthlyFee = 10;
        double interestRate = 0.05;
       

        public override void CalculateInterest()
        {
            Console.WriteLine("-----------Savings Account-------------");
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Current Balance: "+Balance);
            double Interest = Balance * interestRate;
            Balance = Balance + Interest;
            Console.WriteLine("Interest: " + Interest);
            Console.WriteLine("New Balance Is: " + Balance);
            Console.WriteLine();


        }
        public void ApplyMaintenanceFee()
        {
            Balance = Balance - monthlyFee * 12;
            
            Console.WriteLine("Maintenance fee deducted: " + monthlyFee * 12);
            Console.WriteLine("Balance after the maintenance fee deduction is: " + Balance);
            Console.WriteLine();
        }
    }
}
