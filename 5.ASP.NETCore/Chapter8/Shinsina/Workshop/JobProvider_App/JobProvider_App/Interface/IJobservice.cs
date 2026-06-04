using JobProvider_App.DTO;

namespace JobProvider_App.Interface
{
    public interface IJobservice
    {
        Task<List<JobDTO>> GetJobsByProviderIdAsync(int providerId);
        Task<bool> AddJobAsync(JobDTO jobDto, int providerId);
        Task<bool> UpdateJobAsync(JobDTO jobDto);
        Task<bool> DeleteJobAsync(int jobId);
    }
}
