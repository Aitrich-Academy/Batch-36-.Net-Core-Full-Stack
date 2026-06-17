using HireMeNow_MVC_Exc.Models;

namespace HireMeNow_MVC_Exc.Interfaces
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAllJobsAsync();

        Task<Job?> GetJobAsync(Guid jobId);
       

        Task AddApplicationAsync(JobApplication application);

        Task<List<JobApplication>> GetAppliedJobsByUserAsync(Guid userId);

        


    }
}
