using JobProvider_App.Model;

namespace JobProvider_App.Interface
{
    public interface IJobProviderRepository
    {
        Task<JobProvider> GetByEmailAsync(string email);
        Task AddAsync(JobProvider jobProvider);
    }
}
