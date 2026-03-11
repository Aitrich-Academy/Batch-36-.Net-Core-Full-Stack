using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_2_Constructors
{
    internal class Employee
    {
        public string Name;

        public Employee(string name) 
        {
            Name = name;
        }
        public void DisplayHead()
        {
            Console.WriteLine("\n------ Q3 ------");
        }

        public void DisplayEmployee()
        {
           
            Console.WriteLine("Employee Name :" + Name);
        }
    }
}
