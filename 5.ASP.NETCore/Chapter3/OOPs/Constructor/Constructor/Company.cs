using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{// static constructor
    internal class Company
    {
       
        public static string companyName;
        public string employeeName;

      
        static Company()
        {
            companyName = "Tech Solutions Pvt Ltd";
            Console.WriteLine("Company registered: " + companyName);
        }

   
        public Company(string name)
        {
            employeeName = name;
            Console.WriteLine(employeeName + " joined the company.");
        }

 
        public void Display()
        {
            Console.WriteLine("Employee: " + employeeName + ", Company: " + companyName);
        }
    }
}
