using System;
using System.Collections.Generic;
using System.Text;
using Exercise2.Model;

namespace Exercise2.Utils
{
    public class Printer
    {
        

        public void Print(Job[] jobs) 
        {

            Console.WriteLine("Id\t|\tTitle\t|\tCompany\t|\tSalary Range");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            foreach (var job in jobs)
            {
                if (job != null)
                {
                    Console.WriteLine($"{job.Id}\t|\t{job.Title}\t|\t{job.Company}\t|\t{job.SalaryRange}");
                }
               
            }
        }

        public void Print(User[] registrations)
        {
            Console.WriteLine("Id\t|\tFName\t|\tLName\t|\tEmail\t|\tRole");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            foreach (var user in registrations)
            {
                if (user != null)
                {
                    
                    Console.WriteLine($"{user.Id}\t|\t{user.FirstName}\t|\t{user.LastName}\t|\t{user.Email}\t|\t{user.Role}");
                }
                
            }
        }
    }
}
