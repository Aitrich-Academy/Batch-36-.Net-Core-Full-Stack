using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Activity_2
{
    internal class Employee : Person
    {
        public double Salary;

        public Employee(string name, int age, double salary)
        : base(name, age)
        {
            Salary = salary;
        }

        public void DisplaySalary()
        {
            Console.WriteLine("Salary: " + Salary);
        }
    }
}
