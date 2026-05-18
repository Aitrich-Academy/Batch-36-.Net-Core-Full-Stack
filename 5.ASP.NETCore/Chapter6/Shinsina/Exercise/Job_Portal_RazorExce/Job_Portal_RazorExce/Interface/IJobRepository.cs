using Job_Portal_RazorExce.DTO;
using Job_Portal_RazorExce.Model;

namespace Job_Portal_RazorExce.Interface
{
    public interface IJobRepository
    {
        void AddJob(Job job);
        List<Job> GetAllJobs();
        void ApplyJob(JobApplication application);
        List<Job> GetAppliedJobs(int userId);
        //List<JobWithStatusDTO> GetJobsWithStatus(int userId);
    }
}
