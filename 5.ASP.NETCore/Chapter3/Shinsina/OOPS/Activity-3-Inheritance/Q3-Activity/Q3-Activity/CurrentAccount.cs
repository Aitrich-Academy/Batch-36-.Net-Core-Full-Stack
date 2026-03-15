using System;
using System.Collections.Generic;
using System.Text;

namespace Q3_Activity
{
    public class CurrentAccount : Account
    {
        public double overdraftLimit;

        public void checkOverdraft()
        {
            if (balance < 0 && Math.Abs(balance) > overdraftLimit)
            {
                Console.WriteLine("Overdraft limit exceeded");
            }
            else
            {
                Console.WriteLine("Within overdraft limit");
            }
        }
    }
}
