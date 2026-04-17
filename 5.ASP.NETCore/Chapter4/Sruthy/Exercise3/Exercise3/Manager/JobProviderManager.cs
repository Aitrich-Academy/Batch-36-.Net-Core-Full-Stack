using Exercise3.Interface;
using Exercise3.Model;
using Exercise3.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Exercise3.Repository;
namespace Exercise3.Manager
{
    public class JobProviderManager : IMenu
    {
        IJobRepository repo = new JobRepository();
        private readonly IApplicationRepository appRepo;
        public JobProviderManager()
        {
            
            appRepo = new ApplicationRepository();
        }
        private IInterviewRepository interviewRepo = new InterviewRepository();

        public void DisplayMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Job Provider Menu ---");
                Console.WriteLine("\n1. Jobs\n2. Applications\n3. Interviews\n4. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        JobMenu();
                        break;

                    case "2":
                        ShowApplications();
                        break;
                    case "3":
                        InterviewMenu();
                        break;

                    case "4":
                        exit = true;
                        break;
                }
            }
        }

        private void JobMenu()
        {
            bool back = false;

            while (!back)
            {
                Console.WriteLine("\n1. List jobs\n2. Post job\n3. Back");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PostJob();
                        break;


                    case "2":
                        ListJobs();
                        break;
                        

                    case "3":
                        back = true;
                        break;
                }
            }
        }

        private void PostJob()
        {
            Job job = new Job();

            Console.Write("Enter Job title: ");
            job.Title = Console.ReadLine();

            Console.Write("Enter Job location: ");
            job.Location = Console.ReadLine();

            Console.Write("Enter Job Type: ");
            job.JobType = Console.ReadLine();

            Console.Write("Enter Job salary range: ");
            job.SalaryRange = Console.ReadLine();

            Console.Write("Enter Job company: ");
            job.Company = Console.ReadLine();

            repo.AddJob(job);

            Console.WriteLine("Job posted successfully.");
        }

        private void ListJobs()
        {
            var jobs = repo.GetAllJobs();

            Console.WriteLine("\nJobs:\n");

            Console.WriteLine("Id | Title | Description | Company | Location | SalaryRange | JobType");
            Console.WriteLine("---------------------------------------------------------------------");

            foreach (var j in jobs)
            {
                Console.WriteLine($"{j.Id} | {j.Title} |  {j.Company} | {j.Location} | {j.SalaryRange} | {j.JobType}");
            }
        }

        private void ShowApplications()
        {
            var apps = appRepo.GetAllApplications();

            Console.WriteLine("\nApplications:\n");
            Console.WriteLine("Id | JobId | Name | Location | Qualification | Experience");
            Console.WriteLine("----------------------------------------------------------");

            if (apps.Count == 0)
            {
                Console.WriteLine("No applications found.");
                return;
            }

            foreach (var a in apps)
            {
                Console.WriteLine($"{a.Id} | {a.JobId} | {a.Name} | {a.Location} | {a.Qualification} | {a.Experience}");
            }
        }

        private void InterviewMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Interview Menu ---");
                Console.WriteLine("1. Schedule Interview");
                Console.WriteLine("2. List Interviews");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ScheduleInterview();
                        break;

                    case "2":
                        ListInterviews();
                        break;

                    case "3":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        private void ScheduleInterview()
        {
            try
            {
                Interview interview = new Interview();

                Console.Write("Enter Company Name: ");
                interview.CompanyName = Console.ReadLine();

                Console.Write("Enter Job Post: ");
                interview.JobPost = Console.ReadLine();

                Console.Write("Enter Interview Date (yyyy-MM-dd): ");
                DateOnly date;
                while (!DateOnly.TryParse(Console.ReadLine(), out date))
                {
                    Console.WriteLine("Invalid date format. Try again:");
                }
                interview.interviewDate = date;

                Console.Write("Enter Interview Time (HH:mm): ");
                TimeOnly time;
                while (!TimeOnly.TryParse(Console.ReadLine(), out time))
                {
                    Console.WriteLine("Invalid time format. Try again:");
                }
                interview.interviewTime = time;

                Console.Write("Enter Online/Location: ");
                interview.InterviewType = Console.ReadLine();

                interviewRepo.AddInterview(interview);


                Console.WriteLine("Interview scheduled successfully!");
            }
            catch
            {
                Console.WriteLine("Error scheduling interview");
            }
        }

        private void ListInterviews()
        {
            var interviews = interviewRepo.GetAllInterviews();

            Console.WriteLine("\n--- Interviews ---");

            if (interviews.Count == 0)
            {
                Console.WriteLine("No interviews scheduled.");
                return;
            }
            Console.WriteLine("\n--- Interviews ---");

            Console.WriteLine("Id | Company | JobPost | Date | Time | Type");
            Console.WriteLine("----------------------------------------------------------");

            foreach (var i in interviews)
            {
                Console.WriteLine($"{i.Id} | {i.CompanyName} | {i.JobPost} | {i.interviewDate.ToString("dd-MM-yyyy")} | {i.interviewTime.ToString("HH:mm")} | {i.InterviewType}");
            }
        }
    }
}
