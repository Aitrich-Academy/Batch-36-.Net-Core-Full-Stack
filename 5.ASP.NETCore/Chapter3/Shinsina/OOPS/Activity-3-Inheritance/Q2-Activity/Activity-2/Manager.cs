using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_2
{
    internal class Manager : Employee
    {
        public string Department;

        public Manager(string name, int age, double salary,string department)
       : base(name, age,salary)
        {
            Department = department;
        }
        public void DisplayDepartment()
        {
            Console.WriteLine("Department: " + Department);
        }
    }
}
