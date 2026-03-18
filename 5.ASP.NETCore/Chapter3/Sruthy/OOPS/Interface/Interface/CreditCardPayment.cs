using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal class CreditCardPayment :IPayment
    {
        public double Pay(double amount)
        {
            return amount;
        }
        public double Refund(double amount)
        {
            return amount;
        }

    }
}
