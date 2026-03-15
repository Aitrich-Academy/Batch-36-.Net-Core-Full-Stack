using System;
using System.Collections.Generic;
using System.Text;
using Workshop1.Interface;
using Workshop1.Model;

namespace Workshop1.Manager
{
    internal class JobManager:IJob
    {
        Job[] jobs = new Job[100];

       
        static int jobCount = 0;

        
        public void PostJob()
        {
            if (jobCount >= 100)
            {
                Console.WriteLine("Job limit reached");
                return;
            }

            Job j = new Job();

            Console.Write("Enter Job Id: ");
            j.id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Title: ");
            j.title = Console.ReadLine();

            Console.Write("Enter Description: ");
            j.description = Console.ReadLine();

            Console.Write("Enter Salary: ");
            j.salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Location: ");
            j.location = Console.ReadLine();

            jobs[jobCount] = j;
            jobCount++;

            Console.WriteLine("Job Posted Successfully");
        }

        public void ListJobs()
        {
            if (jobCount == 0)
            {
                Console.WriteLine("No Jobs Available");
                return;
            }

            for (int i = 0; i < jobCount; i++)
            {
                Console.WriteLine("\nJob ID: " + jobs[i].id);
                Console.WriteLine("Title: " + jobs[i].title);
                Console.WriteLine("Description: " + jobs[i].description);
                Console.WriteLine("Salary: " + jobs[i].salary);
                Console.WriteLine("Location: " + jobs[i].location);
            }
        }
    }
}
