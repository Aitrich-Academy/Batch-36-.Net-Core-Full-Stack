using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_6_Polymorphism
{
    internal class Flight : Transport
    {
        public override void Fare()
        {
            Console.WriteLine("Flight fare:Rs 3000");
        }
    }
}
