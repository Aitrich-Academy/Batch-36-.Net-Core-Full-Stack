using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Constructor
{
    internal class Employee
    {
        // parameterized constructor
        public string name;
        public int age;
        public Employee(string n,int d)
        {
            name = n;
            age = d;
        }
    }
}
