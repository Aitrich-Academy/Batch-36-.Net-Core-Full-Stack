using System;
using System.Collections.Generic;
using System.Text;

namespace MachineTest
{
    internal class CurrentAccount :Account
    {
        SavingsAccount a=new SavingsAccount();
        public override void CalculateInterest()
        {
            Console.WriteLine("--------------Current Account-----------------");
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("No Interest applicable for Current Account");
            Console.WriteLine("Your Account Balance is: "+Balance);
        }
        public void ApplyMaintenanceFee()
        {
            Balance = Balance - a.monthlyFee*12;
            Console.WriteLine("Maintenance fee deducted: " + a.monthlyFee*12);
            Console.WriteLine("Balance after is: " + Balance);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
