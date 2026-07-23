using JobPortal_Activity2_API.DTOs;
using JobPortal_Activity2_API.Models;

namespace JobPortal_Activity2_API.Interfaces
{
    public interface IJobRepository
    {
        Task<IEnumerable<Job>> GetJobsAsync();
        Task<Job> GetJobByIdAsync(int Id);
        Task<Job> AddJobAsync(Job job);
        Task<Job> UpdateJobAsync(Job job);
        Task<bool> DeleteJobAsync(int Id);
    }
}
