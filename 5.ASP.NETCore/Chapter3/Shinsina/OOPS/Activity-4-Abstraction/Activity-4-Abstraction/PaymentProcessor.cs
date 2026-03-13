using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_4_Abstraction
{
    abstract class PaymentProcessor
    {
        protected double amount;

        // Constructor
        public PaymentProcessor(double amt)
        {
            amount = amt;
        }

        // Common Method (Shared Code)
        public void ValidatePayment()
        {
            Console.WriteLine("\nValidating payment of $" + amount);
        }
        public abstract void ProcessPayment();
    }
}
