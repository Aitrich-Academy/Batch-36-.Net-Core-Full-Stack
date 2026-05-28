using JobPortal.DTO;

namespace JobPortal.Interface
{
    public interface IJobService
    {
        Task<IEnumerable<JobDTO>> GetAllJobsAsync();
        Task<JobDTO> GetJobByIdAsync(int id);
        Task AddJobAsync(JobDTO jobDto);
        Task UpdateJobAsync(JobDTO jobDto);
        Task DeleteJobAsync(int id);
        
    }
}
