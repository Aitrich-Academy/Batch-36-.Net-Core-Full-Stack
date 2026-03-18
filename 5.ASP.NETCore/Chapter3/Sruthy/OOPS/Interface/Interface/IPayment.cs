using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal interface IPayment
    {
        public double Pay(double amount);
        public double Refund(double amount);

    }
}
