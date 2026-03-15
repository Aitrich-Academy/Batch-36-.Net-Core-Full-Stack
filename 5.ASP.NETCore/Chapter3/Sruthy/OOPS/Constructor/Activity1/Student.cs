using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    internal class Student
    {
        public string name;
        public int age;

        public Student()
        {
            name = "Unknown";
            age = 0;
        }
        public void displayValues()
        {
            Console.WriteLine("Name: " + name+"\nAge: " + age);

        }
    }
}
