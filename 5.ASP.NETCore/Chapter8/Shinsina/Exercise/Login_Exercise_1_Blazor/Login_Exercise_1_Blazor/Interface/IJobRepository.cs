using Login_Exercise_1_Blazor.Model;

namespace Login_Exercise_1_Blazor.Interface
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAllJobsAsync();
        Task AddJobAsync(Job job);
    }
}
