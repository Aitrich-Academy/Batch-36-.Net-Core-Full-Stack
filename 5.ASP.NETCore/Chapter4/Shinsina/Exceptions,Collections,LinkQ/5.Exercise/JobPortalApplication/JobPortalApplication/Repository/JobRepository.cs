using JobPortalApplication.Interfaces;
using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Repository
{
    public class JobRepository : IJobRepository
    {
        private List<Job> jobs = new List<Job>();

        public void AddJob(Job job)
        {
            jobs.Add(job);
        }

        public List<Job> GetJobs()
        {
            return jobs;
        }
    }
}
