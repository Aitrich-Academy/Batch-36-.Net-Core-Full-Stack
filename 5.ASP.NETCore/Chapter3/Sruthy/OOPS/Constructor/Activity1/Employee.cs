using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    internal class Employee
    {
        public string name;
        public Employee(string name) 
        {
            this.name = name;
        }
        public void infoEmployee() 
        {
            Console.WriteLine("Employee Details\n---------------------------\n" + name+"\n");
        }

    }
}
