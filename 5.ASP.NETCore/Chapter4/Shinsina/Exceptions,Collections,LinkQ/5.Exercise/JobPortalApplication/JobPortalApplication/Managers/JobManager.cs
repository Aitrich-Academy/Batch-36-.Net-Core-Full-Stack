using JobPortalApplication.Enums;
using JobPortalApplication.Exceptions;
using JobPortalApplication.Models;
using JobPortalApplication.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace JobPortalApplication.Managers
{
   
    public class JobManager
    {
        

        public JobManager(JobRepository repository)
        {
            repo = repository;
        }
        JobRepository repo = new JobRepository();
        Lists list = new Lists();
        private JobRepository jobRepo = new JobRepository();
        public void PostJob()
        {
            try
            {
                Job job = new Job();

                Console.Write("Enter job title: ");
                job.Title = Console.ReadLine();
               
               

                Console.Write("Enter description: ");
                job.Description = Console.ReadLine();

                Console.Write("Experience (Fresher, Junior, Senior): ");
                Experience exp;
                while (!Enum.TryParse<Experience>(Console.ReadLine(), true, out exp))
                {
                    Console.Write("Invalid input. Enter Experience (Fresher, Junior, Senior): ");
                }
                job.Experience = exp;



                Console.Write("Salary: ");
                job.Salary = double.Parse(Console.ReadLine());


                Console.Write("Enter location: ");
                job.Location = Console.ReadLine();

                // Auto-generate Job ID
                job.Id = repo.GetJobs().Count + 1;

                // Add job to repository
                repo.AddJob(job);

                Console.WriteLine("Successfully registered a Job!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ViewJobs()
        {
            var jobs = repo.GetJobs();

            if (jobs.Count == 0)
            {
                Console.WriteLine("No jobs available");
                return;
            }
            list.Print(jobs); // ✅ print full list (optional)

            //foreach (var j in jobs)
            //{
            //    //Console.WriteLine($"{j.Id} | {j.Title} | {j.Location} | {j.Salary}");
            //}
           
        }
    }
}
