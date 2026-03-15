using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_4_Abstraction
{
    internal class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat will meaw meaw");
        }
    }
}
