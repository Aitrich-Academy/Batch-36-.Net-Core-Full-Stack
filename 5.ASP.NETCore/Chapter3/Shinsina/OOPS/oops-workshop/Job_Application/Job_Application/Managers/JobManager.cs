//using Job_Application.Enums;
//using Job_Application.Models;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Job_Application.Managers
//{
//    public class JobManager
//    {
//        private Job[] jobs = new Job[5];

//        public JobManager()
//        {
//            // Sample jobs
//            jobs[0] = new Job { Id = 1, Title = "Software Developer", Company = "TechCorp", Location = "Doha", ExperienceLevel = ExperienceLevels.Fresher, SalaryRange = "QAR 5000-7000", JobType = "Full-Time" };
//            jobs[1] = new Job { Id = 2, Title = "Junior .NET Developer", Company = "CodeWorks", Location = "Doha", ExperienceLevel = ExperienceLevels.Junior, SalaryRange = "QAR 6000-8000", JobType = "Full-Time" };
//            jobs[2] = new Job { Id = 3, Title = "Senior Developer", Company = "SoftSolutions", Location = "Doha", ExperienceLevel = ExperienceLevels.Senior, SalaryRange = "QAR 12000-15000", JobType = "Full-Time" };
//            jobs[3] = new Job { Id = 4, Title = "Frontend Developer", Company = "WebLab", Location = "Doha", ExperienceLevel = ExperienceLevels.MidLevel, SalaryRange = "QAR 8000-10000", JobType = "Full-Time" };
//            jobs[4] = new Job { Id = 5, Title = "Backend Developer", Company = "DevHouse", Location = "Doha", ExperienceLevel = ExperienceLevels.MidLevel, SalaryRange = "QAR 8500-10500", JobType = "Full-Time" };
//        }

//        public void ShowJobs()
//        {
//            Console.WriteLine("\nAvailable Jobs:");
//            foreach (var job in jobs)
//            {
//                Console.WriteLine($"Id: {job.Id} | {job.Title} | {job.Company} | {job.Location} | {job.ExperienceLevel} | {job.SalaryRange} | {job.JobType}");
//            }
//        }

//        public Job GetJobById(int id)
//        {
//            foreach (var job in jobs)
//            {
//                if (job != null && job.Id == id)
//                    return job;
//            }
//            return null;
//        }

//        public void ApplyJob(Job job)
//        {
//            loggedInJobSeeker?.AddAppliedJob(job);
//        }

//        public void SaveJob(Job job)
//        {
//            loggedInJobSeeker?.AddSavedJob(job);
//        }

//        public void DisplayAppliedJobs()
//        {
//            Job[] jobs = loggedInJobSeeker?.GetAppliedJobs();

//            Console.WriteLine("\nApplied Jobs:");
//            if (jobs == null)
//            {
//                Console.WriteLine("No jobs applied yet.");
//                return;
//            }

//            bool anyApplied = false;

//            foreach (Job job in jobs)
//            {
//                if (job != null)
//                {
//                    Console.WriteLine($"Job Id: {job.Id}");
//                    Console.WriteLine($"Title: {job.Title}");
//                    Console.WriteLine($"Experience Level: {job.ExperienceLevel}");
//                    Console.WriteLine("-------------------------");
//                    anyApplied = true;
//                }
//            }

//            if (!anyApplied)
//            {
//                Console.WriteLine("No jobs applied yet.");
//            }
//        }
//        public void DisplaySavedJobs()
//        {
//            Job[] jobs = loggedInJobSeeker?.GetSavedJobs();

//            Console.WriteLine("\nSaved Jobs:");
//            if (jobs == null)
//            {
//                Console.WriteLine("\nno jobs saved yet");
//                return;
//            }
//            bool anySaved = false;
//            foreach (Job job in jobs)
//            {
//                if (job != null)
//                {
//                    Console.WriteLine($"Job Id: {job.Id}");
//                    Console.WriteLine($"Title: {job.Title}");
//                    Console.WriteLine($"Experience Level: {job.ExperienceLevel}");
//                    Console.WriteLine("-------------------------");
//                    anySaved = true;
//                }
//            }
//            if (!anySaved)
//            {
//                Console.WriteLine("No jobs saved yet.");
//            }


//             private int AppliedJobCount = 0;
//        private int SavedJobCount = 0;

//        private Job[] AppliedJobs = new Job[2];
//        private Job[] SavedJobs = new Job[2];

//        public void AddAppliedJob(Job job)
//        {
//            if (AppliedJobCount < AppliedJobs.Length)
//            {
//                AppliedJobs[AppliedJobCount] = job;
//                Console.WriteLine("Job Applied Successfully...");
//                AppliedJobCount++;
//            }
//            else
//            {
//                Console.WriteLine("Applied Jobs Limit Reached...");
//            }
//        }

//        public Job[] GetAppliedJobs()
//        {
//            return AppliedJobs;
//        }

//        public void AddSavedJob(Job job)
//        {
//            if (SavedJobCount < SavedJobs.Length)
//            {
//                SavedJobs[SavedJobCount] = job;
//                Console.WriteLine("Job Saved Successfully...");
//                SavedJobCount++;
//            }
//            else
//            {
//                Console.WriteLine("Saved Jobs Limit Exceeded...");
//            }
//        }

//        public Job[] GetSavedJobs()
//        {
//            return SavedJobs;
//        }
//    }
//}
