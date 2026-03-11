using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_4_Abstraction
{
    internal class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("\nDogs will bark");
        }
    }
}
