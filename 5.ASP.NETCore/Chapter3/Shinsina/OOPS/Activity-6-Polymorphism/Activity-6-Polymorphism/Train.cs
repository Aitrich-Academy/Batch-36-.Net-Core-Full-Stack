using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_6_Polymorphism
{
    internal class Train:Transport
    {
        public override void Fare()
        {
            Console.WriteLine("Train fare:Rs 100");
        }
    }
}
