using CompanyMemberRegistration.Interfaces;
using CompanyMemberRegistration.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyMemberRegistration.Repository
{
    public class JobRepository:IJobRepository
    {
        public JobRepository()
        {

        }
        List<Job> jobs = new List<Job>();

        public List<Job> GetAllJobs()
        {
            return jobs;
        }
    }
}
