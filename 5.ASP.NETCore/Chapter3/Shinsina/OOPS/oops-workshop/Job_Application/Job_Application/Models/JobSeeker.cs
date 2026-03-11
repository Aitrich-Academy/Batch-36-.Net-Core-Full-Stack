using Job_Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Job_Application.Models
{
    internal class JobSeeker
    {
        private int AppliedJobCount = 0;
        private int SavedJobCount = 0;

        private Job[] AppliedJobs = new Job[2];
        private Job[] SavedJobs = new Job[2];

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string Qualification { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }

        public void AddAppliedJob(Job job)
        {
            if (AppliedJobCount < AppliedJobs.Length)
            {
                AppliedJobs[AppliedJobCount] = job;
                Console.WriteLine("Job Applied Successfully...");
                AppliedJobCount++;
            }
            else
            {
                Console.WriteLine("Applied Jobs Limit Reached...");
            }
        }

        public Job[] GetAppliedJobs()
        {
            return AppliedJobs;
        }

        public void AddSavedJob(Job job)
        {
            if (SavedJobCount < SavedJobs.Length)
            {
                SavedJobs[SavedJobCount] = job;
                Console.WriteLine("Job Saved Successfully...");
                SavedJobCount++;
            }
            else
            {
                Console.WriteLine("Saved Jobs Limit Exceeded...");
            }
        }

        public Job[] GetSavedJobs()
        {
            return SavedJobs;
        }
    }
}
