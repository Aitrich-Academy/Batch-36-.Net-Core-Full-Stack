using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Barks");
        }
    }
}
