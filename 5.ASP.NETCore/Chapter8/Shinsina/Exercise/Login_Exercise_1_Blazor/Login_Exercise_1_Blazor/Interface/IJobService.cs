using Login_Exercise_1_Blazor.Model;
using Login_Exercise_1_Blazor.DTO;

namespace Login_Exercise_1_Blazor.Interface
{
    public interface IJobService
    {
        Task<List<Job>> GetAllJobsAsync();
        Task AddJobAsync(JobDTO dto);
    }
}
