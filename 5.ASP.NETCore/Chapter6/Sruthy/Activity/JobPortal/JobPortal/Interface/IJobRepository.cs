using JobPortal.Model;

namespace JobPortal.Interface
{
    public interface IJobRepository
    {
        Task<IEnumerable<Job>> GetAllAsync();
        Task<Job> GetByIdAsync(int id);
        Task AddAsync(Job job);
        Task UpdateAsync(Job job);
        Task DeleteAsync(int id);
    }
}
