using Exercise2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Manager
{
    internal class UserManager
    {
        public void ViewJobs(JobManager jobManager)
        {
            jobManager.ListJobs();
        }

        public void ApplyJob(JobManager jobManager, int jobId)
        {
            Job[] jobs = jobManager.GetJobs();
            Job selectedJob = null;

            foreach (var job in jobs)
            {
                if (job != null && job.Id == jobId)
                {
                    selectedJob = job;
                    break;
                }
            }

            if (selectedJob != null)
            {
                Console.WriteLine($"Successfully applied for Job ID {jobId} - {selectedJob.Title} at {selectedJob.Company}");
            }
            else
            {
                Console.WriteLine($"Job ID {jobId} does not exist.");
            }
        }
    }
}
