using JobPortalApplication.Models;
using JobPortalApplication.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Managers
{
    public class SeekerManager
    {
        JobRepository jobRepo;
      
        private List<Job> savedJobs = new List<Job>();
        private List<Job> appliedJobs = new List<Job>();
        private User loggedUser;

        Lists list = new Lists();
        public SeekerManager(JobRepository repo, User user)
        {
            jobRepo = repo;
            loggedUser = user;

            // ✅ FIX: initialize lists
            if (loggedUser.SavedJobs == null)
                loggedUser.SavedJobs = new List<Job>();

            if (loggedUser.AppliedJobs == null)
                loggedUser.AppliedJobs = new List<Job>();
        }
        //public SeekerManager(JobRepository repo, User user)
        //{
        //    jobRepo = repo;
        //    loggedUser = user;
        //}


        public SeekerManager()
        {
        }
     
        public void ListJobsWithOptions()
        {
            var jobs = jobRepo.GetJobs();

            if (jobs.Count == 0)
            {
                Console.WriteLine("No jobs available");
                return;
            }

            while (true)
            {
                list.Print(jobs);

                Console.WriteLine("\n1.Save Job  2.Apply Job  3.Back");
                Console.Write("Choose option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 3)
                    return;

                Console.Write("Enter Job Id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                var job = jobs.FirstOrDefault(j => j.Id == id);

                if (job == null)
                {
                    Console.WriteLine("Invalid Job Id");
                    continue;
                }

                // 🔥 SAVE JOB
                if (choice == 1)
                {
                    if (loggedUser.SavedJobs.Any(j => j.Id == id))
                        //if (savedJobs.Any(j => j.Id == id))
                    {
                        Console.WriteLine("Job already saved");
                    }
                    else
                    {
                        loggedUser.SavedJobs.Add(job);
                        //savedJobs.Add(job);
                        Console.WriteLine("Job saved successfully");
                    }
                }

                // 🔥 APPLY JOB
                else if (choice == 2)
                {
                    if (loggedUser.AppliedJobs.Any(j => j.Id == id))
                        //if (appliedJobs.Any(j => j.Id == id))
                    {
                        Console.WriteLine("Already applied for this job");
                    }
                    else
                    {
                        loggedUser.AppliedJobs.Add(job);
                        //appliedJobs.Add(job);
                        Console.WriteLine("Job applied successfully");
                    }
                }
            }
        }
        public void SaveJob(Job job)
        {
            if (loggedUser.SavedJobs.Any(j => j.Id == job.Id))
            {
                Console.WriteLine("Job already saved!");
                return;
            }

            loggedUser.SavedJobs.Add(job);
            Console.WriteLine("Job saved successfully!");
        }

        public void ApplyJob(Job job)
        {
            if (loggedUser.AppliedJobs.Any(j => j.Id == job.Id))
            {
                Console.WriteLine("Job already applied!");
                return;
            }

            loggedUser.AppliedJobs.Add(job);
            Console.WriteLine("Job applied successfully!");
        }

        public void ViewSavedJobs()
        {
            Console.WriteLine("\nSaved Jobs:");
            list.PrintSavedJobs(loggedUser.SavedJobs);
        }

        public void ViewAppliedJobs()
        {
            Console.WriteLine("\nApplied Jobs:");
            list.PrintAppliedJobs(loggedUser.AppliedJobs);
        }
        public void Profile(User user)
        {
            Console.WriteLine("\nMy Profile");
            Console.WriteLine($"ID: {user.Id}");
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"Role: {user.Role}");
        }

        public void Logout()
        {
            loggedUser = null;
            Console.WriteLine("Logged out successfully!");
        }
    }
}
