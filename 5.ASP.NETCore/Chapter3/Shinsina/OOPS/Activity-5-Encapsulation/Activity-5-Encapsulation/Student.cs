using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Activity_5_Encapsulation
{
    internal class Student
    {
        private string name;
        private int age;


        // Public Property for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Public Property for Age with validation
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Age cannot be negative.");
            }
        }
    }
}
