using HireMeNow_Wrkshp_MVC.Interface;
using HireMeNow_Wrkshp_MVC.Models;

namespace HireMeNow_Wrkshp_MVC.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly HireMeNowContext _context;

        public JobRepository(HireMeNowContext context)
        {
            _context = context;
        }

        public bool Create(Job job)
        {
            _context.Jobs.Add(job);
            return _context.SaveChanges() > 0;
        }

        public List<Job> GetAllByCompanyId(int companyId)
        {
            return _context.Jobs
                .Where(x => x.CompanyId == companyId)
                .ToList();
        }

        public Job GetJobById(int id)
        {
            return _context.Jobs.FirstOrDefault(j => j.JobId == id);
        }

        public bool Update(Job job)
        {
            _context.Jobs.Update(job);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var job = _context.Jobs.Find(id);

            if (job == null)
                return false;

            _context.Jobs.Remove(job);

            return _context.SaveChanges() > 0;
        }
    }
}
