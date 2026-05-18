using Job_Portal_RazorExce.DTO;
using Job_Portal_RazorExce.Model;

namespace Job_Portal_RazorExce.Interface
{
    public interface IJobService
    {
        List<JobDTO> GetJobs(int userId);

        void ApplyJob(JobApplicationDTO dto);

        List<JobDTO> GetAppliedJobs(int userId);
    }
}
