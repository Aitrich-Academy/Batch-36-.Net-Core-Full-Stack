using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_6_Polymorphism
{
    internal class Bus:Transport
    {
        public override void Fare()
        {
            Console.WriteLine("Bus fare: 50");
        }
    }
}
