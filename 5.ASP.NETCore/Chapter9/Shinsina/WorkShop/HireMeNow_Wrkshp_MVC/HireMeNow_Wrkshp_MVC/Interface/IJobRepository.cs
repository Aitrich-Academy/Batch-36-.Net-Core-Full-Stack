using HireMeNow_Wrkshp_MVC.Models;

namespace HireMeNow_Wrkshp_MVC.Interface
{
    public interface IJobRepository
    {
        bool Create(Job job);

        List<Job> GetAllByCompanyId(int companyId);

        //Job GetById(int id);
        Job GetJobById(int id);
        bool Update(Job job);

        bool Delete(int id);
    }
}
