using System;
using System.Collections.Generic;
using System.Text;
using static Job_Application.Enums.ExperienceLevel;

namespace Job_Application.Models
{
    internal class JobSeeker
    {
        int AppliedJobCount = 0;
        int SavedJobCount = 0;

        private Job[] AppliedJobs = new Job[3];
        private Job[] SavedJobs = new Job[3];

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string Qualification { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }

        



        public void AddAppliedJob(Job job)
        {
            if (AppliedJobCount < 3)
            {
                AppliedJobs[AppliedJobCount] = job;
                Console.WriteLine("Job Applied Successfully...");
                AppliedJobCount++;
            }
            else
            {
                Console.WriteLine("Limit Reached....");
            }
        }

        public Job[] GetAppliedJobs()
        {
            return AppliedJobs;
        }

        public void addSavedJob(Job job)
        {
            if (SavedJobCount < 3)
            {
                SavedJobs[SavedJobCount] = job;
                Console.WriteLine("Saved Job Successfully...");
                SavedJobCount++;
            }
            else
            {
                Console.WriteLine("Limit Exceeded...");
            }
        }

        public Job[] GetSavedJob()
        {
            return SavedJobs;
        }
    }

}

