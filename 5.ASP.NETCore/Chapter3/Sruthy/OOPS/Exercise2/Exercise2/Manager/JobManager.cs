using Exercise2.Model;
using Exercise2.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Manager
{
    class JobManager
    {
        private Job[] jobs = new Job[100];
        private int jobCount = 0;
        private Printer printer = new Printer();

        public void AddJob(Job job)
        {
            job.Id = jobCount+1;
            jobs[jobCount++] = job;
        }

        public void ListJobs()
        {
            Job[] temp = new Job[jobCount];
            Array.Copy(jobs, temp, jobCount);
            printer.Print(temp);
        }

        public Job[] GetJobs()
        {
            Job[] temp = new Job[jobCount];
            Array.Copy(jobs, temp, jobCount);
            return temp;
        }
    }
}
