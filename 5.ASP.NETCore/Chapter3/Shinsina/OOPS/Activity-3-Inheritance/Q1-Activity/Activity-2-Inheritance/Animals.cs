using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_2_Inheritance
{
    class Animals
    {
        public string Name;

        public Animals(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine(Name+" :Animal is eating");
        }
    }
}
