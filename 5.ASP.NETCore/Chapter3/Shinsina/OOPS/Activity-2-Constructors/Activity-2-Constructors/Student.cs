using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_2_Constructors
{
    internal class Student
    {
        public string Name;
        public int Age;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine("\n------ Q1 ------");
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
