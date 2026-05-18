using JobPortalManagment.DTO;
//using JobPortalManagment.Model;

namespace JobPortalManagment.Interface
{
    public interface IJobService
    {
      
        Task AddJob(JobDTO jobDTO);
        Task<List<JobDTO>> GetAllJobs();
        Task<JobDTO> GetJobById(int id);
        Task UpdateJob(JobDTO dto);
        Task DeleteJob(int id);
        
    }
}
