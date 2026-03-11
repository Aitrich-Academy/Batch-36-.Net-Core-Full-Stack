using Job_Application.Enums;
using Job_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Job_Application.Managers
{
    internal class JobSeekerManager
    {
        private Job[] jobs = new Job[5];

        public JobSeekerManager()
        {
            // Sample jobs
            jobs[0] = new Job { Id = 1, Title = "Software Developer", Company = "TechCorp", Location = "Doha", ExperienceLevel = ExperienceLevels.Fresher, SalaryRange = "QAR 5000-7000", JobType = "Full-Time" };
            jobs[1] = new Job { Id = 2, Title = "Junior .NET Developer", Company = "CodeWorks", Location = "Doha", ExperienceLevel = ExperienceLevels.Junior, SalaryRange = "QAR 6000-8000", JobType = "Full-Time" };
            jobs[2] = new Job { Id = 3, Title = "Senior Developer", Company = "SoftSolutions", Location = "Doha", ExperienceLevel = ExperienceLevels.Senior, SalaryRange = "QAR 12000-15000", JobType = "Full-Time" };
            jobs[3] = new Job { Id = 4, Title = "Frontend Developer", Company = "WebLab", Location = "Doha", ExperienceLevel = ExperienceLevels.MidLevel, SalaryRange = "QAR 8000-10000", JobType = "Full-Time" };
            jobs[4] = new Job { Id = 5, Title = "Backend Developer", Company = "DevHouse", Location = "Doha", ExperienceLevel = ExperienceLevels.MidLevel, SalaryRange = "QAR 8500-10500", JobType = "Full-Time" };
        }

        public void ShowJobs()
        {
            Console.WriteLine("\nAvailable Jobs:");
            foreach (var job in jobs)
            {
                Console.WriteLine($"Id: {job.Id} | {job.Title} | {job.Company} | {job.Location} | {job.ExperienceLevel} | {job.SalaryRange} | {job.JobType}");
            }
        }

        public Job GetJobById(int id)
        {
            foreach (var job in jobs)
            {
                if (job != null && job.Id == id)
                    return job;
            }
            return null;
        }






        private JobSeeker[] jobSeekers = new JobSeeker[2];
        private int JobSeekerCount = 0;

        public JobSeeker loggedInJobSeeker = null;

        public void RegisterJobSeeker()
        {
            if (JobSeekerCount >= jobSeekers.Length)
            {
                Console.WriteLine("Job Seeker registration limit reached!");
                return;
            }

            JobSeeker newJobSeeker = new JobSeeker();

            Console.Write("\nEnter your First Name: ");
            newJobSeeker.FirstName = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            newJobSeeker.LastName = Console.ReadLine();

            Console.Write("Enter your Email: ");
            newJobSeeker.Email = Console.ReadLine();

            Console.Write("Enter your Password: ");
            newJobSeeker.Password = Console.ReadLine();

            Console.Write("Enter your Phone Number: ");
            newJobSeeker.Phone = Console.ReadLine();

            Console.Write("Enter your Location: ");
            newJobSeeker.Location = Console.ReadLine();

            Console.Write("About Yourself: ");
            newJobSeeker.AboutMe = Console.ReadLine();

            Console.Write("Enter your Qualification: ");
            newJobSeeker.Qualification = Console.ReadLine();

            Console.Write("Enter your Experience Level (Fresher, Junior, MidLevel, Senior): ");
            string input = Console.ReadLine();
            newJobSeeker.ExperienceLevel = (ExperienceLevels)Enum.Parse(typeof(ExperienceLevels), input, true);

            jobSeekers[JobSeekerCount] = newJobSeeker;
            JobSeekerCount++;

            Console.WriteLine("\nRegistration completed successfully!");
        }

        public bool LoginJobSeeker()
        {
            Console.Write("\nEnter your Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your Password: ");
            string password = Console.ReadLine();

            foreach (JobSeeker seeker in jobSeekers)
            {
                if (seeker != null && seeker.Email == email && seeker.Password == password)
                {
                    loggedInJobSeeker = seeker;
                    return true;
                }
            }
            return false;
        }

        public void ShowJobSeekerMenu()
        {
            Console.WriteLine("\n1. Profile");
            Console.WriteLine("2. View All Jobs");
            Console.WriteLine("3. Apply/Save Job");
            Console.WriteLine("4. View Applied Jobs");
            Console.WriteLine("5. View Saved Jobs");
            Console.WriteLine("6. Logout");
           

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowJobSeekerProfile();
                    ShowJobSeekerMenu();
                    break;
                case "2":
                    JobSeekerManager jobManager = new JobSeekerManager();
                    jobManager.ShowJobs();
                    ShowJobSeekerMenu();
                   
                    break;
                case "3":
                    JobSeekerManager jm = new JobSeekerManager();
                    jm.ShowJobs();
                    Console.Write("\nEnter Job Id to Apply/Save: ");
                    int jobId = Convert.ToInt32(Console.ReadLine());
                    Job selectedJob = jm.GetJobById(jobId);
                    if (selectedJob != null)
                    {
                        Console.WriteLine("1. Apply\n2. Save");
                        string action = Console.ReadLine();
                        if (action == "1") ApplyJob(selectedJob);
                        else if (action == "2") SaveJob(selectedJob);
                        else Console.WriteLine("Invalid Choice");
                    }
                    else
                    {
                        Console.WriteLine("Job not found!");
                    }
                    ShowJobSeekerMenu();

                   
                    break;
                case "4":
                    DisplayAppliedJobs();
                    ShowJobSeekerMenu();
                    break;
                case "5":
                    DisplaySavedJobs();
                    ShowJobSeekerMenu();
                    break;

                case "6":
                    Logout();
                   
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    ShowJobSeekerMenu();
                    break;
            }
        }

        public void ShowJobSeekerProfile()
        {
            if (loggedInJobSeeker == null) return;

            Console.WriteLine("\n-------------------------------MY PROFILE-------------------------------------\n");
            Console.WriteLine($"First Name: {loggedInJobSeeker.FirstName}");
            Console.WriteLine($"Last Name: {loggedInJobSeeker.LastName}");
            Console.WriteLine($"Email: {loggedInJobSeeker.Email}");
            Console.WriteLine($"Phone: {loggedInJobSeeker.Phone}");
            Console.WriteLine($"Location: {loggedInJobSeeker.Location}");
            Console.WriteLine($"AboutMe: {loggedInJobSeeker.AboutMe}");
            Console.WriteLine($"Qualification: {loggedInJobSeeker.Qualification}");
            Console.WriteLine($"ExperienceLevel: {loggedInJobSeeker.ExperienceLevel}");
            Console.WriteLine("\n");
        }

        public void Logout()
        {
            loggedInJobSeeker = null;
            Console.WriteLine("\nLogged out successfully!");
            ShowMainMenu();
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("\nWelcome to Job Portal - Job Seeker Portal!");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterJobSeeker();
                    ShowMainMenu();
                    break;
                case "2":
                    bool loginRes = LoginJobSeeker();
                    if (loginRes)
                    {
                        Console.WriteLine($"Welcome {loggedInJobSeeker.FirstName}!");
                        ShowJobSeekerMenu();
                    }
                    else
                    {
                        Console.WriteLine("Login failed. Try again.");
                        ShowMainMenu();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    ShowMainMenu();
                    break;
            }
        }

        public void ApplyJob(Job job)
        {
            loggedInJobSeeker?.AddAppliedJob(job);
        }

        public void SaveJob(Job job)
        {
            loggedInJobSeeker?.AddSavedJob(job);
        }

        public void DisplayAppliedJobs()
        {
            Job[] jobs = loggedInJobSeeker?.GetAppliedJobs();

            Console.WriteLine("\nApplied Jobs:");
            if (jobs == null)
            {
                Console.WriteLine("No jobs applied yet.");
                return;
            }

            bool anyApplied = false;

            foreach (Job job in jobs)
            {
                if (job != null)
                {
                    Console.WriteLine($"Job Id: {job.Id}");
                    Console.WriteLine($"Title: {job.Title}");
                    Console.WriteLine($"Experience Level: {job.ExperienceLevel}");
                    Console.WriteLine("-------------------------");
                    anyApplied = true;
                }
            }

            if (!anyApplied)
            {
                Console.WriteLine("No jobs applied yet.");
            }
        }
        public void DisplaySavedJobs()
        {
            Job[] jobs = loggedInJobSeeker?.GetSavedJobs();

            Console.WriteLine("\nSaved Jobs:");
            if (jobs == null)
            {
                Console.WriteLine("\nno jobs saved yet");
                return;
            }
            bool anySaved = false;
            foreach (Job job in jobs)
            {
                if (job != null)
                {
                    Console.WriteLine($"Job Id: {job.Id}");
                    Console.WriteLine($"Title: {job.Title}");
                    Console.WriteLine($"Experience Level: {job.ExperienceLevel}");
                    Console.WriteLine("-------------------------");
                    anySaved = true;
                }
            }
            if (!anySaved)
            {
                Console.WriteLine("No jobs saved yet.");
            }
        }
    }
}
