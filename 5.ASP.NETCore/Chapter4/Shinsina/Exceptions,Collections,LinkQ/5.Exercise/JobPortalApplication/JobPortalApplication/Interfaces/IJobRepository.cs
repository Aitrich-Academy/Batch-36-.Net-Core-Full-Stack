using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Interfaces
{
    public interface IJobRepository
    {
        void AddJob(Job job);
        List<Job> GetJobs();
       
    }
}
