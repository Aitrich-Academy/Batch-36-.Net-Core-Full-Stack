using CompanyMemberRegistration.Interfaces;
using CompanyMemberRegistration.Model;

namespace CompanyMemberRegistration.Manager
{
    public class JobPortal:IJobProvider
    {
        private List<Job> jobs = new List<Job>();
        public void PostJob(Job job)
        {
            job.Id = jobs.Count;
            jobs.Add(job);
        }

        public List<Job> GetJobs()
        {
            return jobs;
        }
    }
}
