using JobProviderApplication.Interface;
using JobProviderApplication.Models;
using System;

namespace JobProviderApplication.Manager
{
    internal class Job_PortalManager : IJobProvider, IApplicationProvider, IInterviewProvider
    {
        private Job[] jobs = new Job[10];
        private Application[] applications = new Application[10];
        private Interview[] interviews = new Interview[10];

        int jobCount = 0;
        int applicationCount = 0;
        int interviewCount = 0;


        // Constructor
        public Job_PortalManager()
        {
            applications[applicationCount++] = new Application
            {
                Id = 1,
                Name = "Rahul",
                Location = "Doha",
                Qualification = "B.Tech",
                Experience = "2 Years"
            };

            applications[applicationCount++] = new Application
            {
                Id = 2,
                Name = "Anjali",
                Location = "Dubai",
                Qualification = "MSc Computer Science",
                Experience = "1 Year"
            };

            applications[applicationCount++] = new Application
            {
                Id = 3,
                Name = "John",
                Location = "Qatar",
                Qualification = "BCA",
                Experience = "Fresher"
            };
        }
        public void PostJob(Job job)
        {
            if (jobCount < jobs.Length)
            {
                job.Id = jobCount + 1;   // automatic id
                jobs[jobCount] = job;
                jobCount++;

                Console.WriteLine("Job posted successfully.");
            }
            else
            {
                Console.WriteLine("Job list is full.");
            }
        }

        public Job[] GetJobs()
        {
            return jobs;
        }

        public void AddApplication(Application application)
        {
            applications[applicationCount++] = application;
        }

        public Application[] GetApplications()
        {
            return applications;
        }

        public void ScheduleInterview(Interview interview)
        {
            interviews[interviewCount++] = interview;
        }

        public Interview[] GetInterviews()
        {
            return interviews;
        }
    }
}