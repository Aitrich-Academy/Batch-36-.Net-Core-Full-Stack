using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Managers
{
    public class Lists
    {
        public void Print(List<Job> jobs)
        {
            Console.WriteLine("Jobs available: \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}   ", "JobId", "Title", "ExperienceLevel", "Location", "SalaryRange");

            foreach (Job job in jobs)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}    ", job.Id, job.Title, job.Experience, job.Location, job.Salary);
            }

            Console.WriteLine("\n");
        }

        public void PrintAppliedJobs(List<Job> job)
        {
            if (job.Count == 0)
            {
                Console.WriteLine("No jobs available");
                return;
            }

            Console.WriteLine("Applied Jobs: \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}   ", "JobId", "Title", "ExperienceLevel", "Location", "SalaryRange");


            foreach (var j in job)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}    ", j.Id, j.Title, j.Experience, j.Location,j.Salary);
            }
        }

        public void PrintSavedJobs(List<Job> jobs)
        {
            if (jobs.Count == 0)
            {
                Console.WriteLine("No jobs available");
                return;
            }

            Console.WriteLine("Saved Jobs: \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}   ", "JobId", "Title", "ExperienceLevel", "Location", "SalaryRange");


            foreach (var j in jobs)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}    ", j.Id, j.Title, j.Experience, j.Location, j.Salary);
            }
        }

    }
}
