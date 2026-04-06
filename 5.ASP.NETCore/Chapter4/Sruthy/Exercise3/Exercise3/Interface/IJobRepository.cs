using Exercise3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Interface
{
    public interface IJobRepository
    {
        List<Job> GetAllJobs();
        void AddJob(Job job);
    }
}
