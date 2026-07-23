using JobPortal_Activity2_API.DTOs;

namespace JobPortal_Activity2_API.Interface
{
    public interface IJobService
    {
        Task<IEnumerable<JobDTO>> GetJobsAsync();
        Task<JobDTO> GetJobByIdAsync(int id);
        Task<JobDTO> AddJobAsync(JobDTO jobDto);
        Task<JobDTO> UpdateJobAsync(int id, JobDTO jobDto);
        Task<bool> DeleteJobAsync(int id);
    }
}
