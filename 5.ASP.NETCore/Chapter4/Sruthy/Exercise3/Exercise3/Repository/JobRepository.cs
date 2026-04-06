using Exercise3.Interface;
using Exercise3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Repository
{
    public class JobRepository : IJobRepository
    {
        private static Dictionary<int, Job> jobs = new Dictionary<int, Job>();
        private static int count = 1;

        public List<Job> GetAllJobs()
        {
            return new List<Job>(jobs.Values);
        }

        public void AddJob(Job job)
        {
            job.Id = count++;
            jobs[job.Id] = job;
        }
    }
}

