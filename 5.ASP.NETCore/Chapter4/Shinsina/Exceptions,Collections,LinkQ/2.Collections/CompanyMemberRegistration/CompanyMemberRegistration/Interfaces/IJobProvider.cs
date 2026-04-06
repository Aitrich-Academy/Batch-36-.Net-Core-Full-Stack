using CompanyMemberRegistration.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyMemberRegistration.Interfaces
{
    public interface IJobProvider
    {
        void PostJob(Job job);
        List<Job> GetJobs();
    }
}
