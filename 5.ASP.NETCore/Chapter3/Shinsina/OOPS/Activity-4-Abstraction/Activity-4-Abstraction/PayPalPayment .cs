using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_4_Abstraction
{
    internal class PayPalPayment:PaymentProcessor
    {
        public PayPalPayment(double amt) : base(amt)
        {
        }

        public override void ProcessPayment()
        {
            ValidatePayment();
            Console.WriteLine("Processing PayPal payment of $" + amount);
        }
    }
}
