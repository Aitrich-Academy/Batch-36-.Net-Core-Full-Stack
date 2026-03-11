using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace JobProviderApplication.Manager
{
    internal class Printer
    {
        public void Print(Job[] jobs)
        {
            Console.WriteLine("\nJobs List");

            foreach (Job job in jobs)
            {
                if (job != null)
                {
                    Console.WriteLine($"Id: {job.Id}");
                    Console.WriteLine($"Title: {job.Title}");
                    Console.WriteLine($"Company: {job.Company}");
                    Console.WriteLine($"Location: {job.Location}");
                    Console.WriteLine($"Salary: {job.Salary}");
                    Console.WriteLine("----------------------");
                }
            }
        }

        public void Print(Application[] applications)
        {
            Console.WriteLine("\nApplications");

            foreach (Application app in applications)
            {
                if (app != null)
                {
                    Console.WriteLine($"Id: {app.Id}");
                    Console.WriteLine($"Name: {app.Name}");
                    Console.WriteLine($"Qualification: {app.Qualification}");
                    Console.WriteLine($"Experience: {app.Experience}");
                    Console.WriteLine("----------------------");
                }
            }
        }

        public void Print(Interview[] interviews)
        {
            Console.WriteLine("\nInterviews");

            foreach (Interview interview in interviews)
            {
                if (interview != null)
                {
                    Console.WriteLine($"Company: {interview.Company}");
                    Console.WriteLine($"Post: {interview.Post}");
                    Console.WriteLine($"Date: {interview.Date}");
                    Console.WriteLine($"Time: {interview.Time}");
                    Console.WriteLine("----------------------");
                }
            }
        }

      
    }
}

