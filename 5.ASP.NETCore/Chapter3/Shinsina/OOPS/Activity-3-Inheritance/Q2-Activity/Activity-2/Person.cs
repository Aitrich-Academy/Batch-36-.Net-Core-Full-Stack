using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_2
{
    internal class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayName()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: "+Age);
        }
    }
}
