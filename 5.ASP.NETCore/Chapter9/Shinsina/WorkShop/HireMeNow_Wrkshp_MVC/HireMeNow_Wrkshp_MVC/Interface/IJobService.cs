using HireMeNow_Wrkshp_MVC.Models;

namespace HireMeNow_Wrkshp_MVC.Interface
{
    public interface IJobService
    {
        List<Job> GetJobsByCompanyId(int companyId);
        Job GetJobById(int id);
        bool Update(Job job);

        bool Delete(int id);
    }
}
