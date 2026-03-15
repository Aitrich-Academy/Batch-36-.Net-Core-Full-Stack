using System;
using System.Collections.Generic;
using System.Text;

namespace MachineTest
{
    abstract class Account
    {
        public string AccountHolder;
        public double Balance;

        public abstract void CalculateInterest();
    }
}
