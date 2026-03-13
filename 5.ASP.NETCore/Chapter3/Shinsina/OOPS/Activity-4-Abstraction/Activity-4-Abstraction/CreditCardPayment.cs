using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_4_Abstraction
{
    internal class CreditCardPayment:PaymentProcessor
    {
        public CreditCardPayment(double amt) : base(amt)
        {
        }

        public override void ProcessPayment()
        {
            ValidatePayment();
            Console.WriteLine("Processing Credit Card payment of $" + amount);
        }
    }
}
