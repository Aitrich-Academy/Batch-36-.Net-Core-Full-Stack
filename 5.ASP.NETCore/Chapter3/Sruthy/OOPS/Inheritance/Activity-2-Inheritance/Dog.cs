using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_2_Inheritance
{
    class Dog : Animals
    {
        public Dog(string name) : base(name)
        {
            name = name.ToLower();
        }

        public void Bark()
        {
            Console.WriteLine(Name+" :Dog is barking");
        }
    }
}
