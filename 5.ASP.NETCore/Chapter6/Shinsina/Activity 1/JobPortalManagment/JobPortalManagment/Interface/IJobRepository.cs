using JobPortalManagment.DTO;
using JobPortalManagment.Migrations.Model;

namespace JobPortalManagment.Interface
{
    public interface IJobRepository
    {
        Task AddJob(Job job);
        Task <List<Job>> GetAllJobs();
        Task<Job> GetJobById(int id);
        Task UpdateJob(Job job);
        Task DeleteJob(int id);
      
    }
}
