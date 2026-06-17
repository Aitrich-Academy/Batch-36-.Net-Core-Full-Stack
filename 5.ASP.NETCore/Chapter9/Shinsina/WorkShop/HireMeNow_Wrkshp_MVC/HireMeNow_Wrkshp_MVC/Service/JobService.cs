using HireMeNow_Wrkshp_MVC.Interface;
using HireMeNow_Wrkshp_MVC.Models;

namespace HireMeNow_Wrkshp_MVC.Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public List<Job> GetJobsByCompanyId(int companyId)
        {
            return _jobRepository.GetAllByCompanyId(companyId);
        }
        public Job GetJobById(int id)
        {
            return _jobRepository.GetJobById(id);
        }
        public bool Update(Job job)
        {
            return _jobRepository.Update(job);
        }

        public bool Delete(int id)
        {
            return _jobRepository.Delete(id);
        }
    }
}
