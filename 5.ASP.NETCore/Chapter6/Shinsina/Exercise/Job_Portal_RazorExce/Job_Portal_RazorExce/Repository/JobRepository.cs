using Job_Portal_RazorExce.DTO;
using Job_Portal_RazorExce.Interface;
using Job_Portal_RazorExce.Model;

namespace Job_Portal_RazorExce.Repository
{
    public class JobRepository : IJobRepository   // 👈 VERY IMPORTANT
    {
        private readonly AppDbContext _context;

        public JobRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddJob(Job job)
        {
            _context.Jobs.Add(job);
            _context.SaveChanges();
        }
        public List<Job> GetAllJobs()
        {
            return _context.Jobs?.ToList() ?? new List<Job>();
        }

        public void ApplyJob(JobApplication application)
        {
           
            _context.JobApplications.Add(application);
            _context.SaveChanges();
        }

        public List<Job> GetAppliedJobs(int userId)
        {
            var jobIds = _context.JobApplications
                .Where(x => x.UserId == userId)
                .Select(x => x.JobId)
                .ToList();

            return _context.Jobs
                .Where(x => jobIds.Contains(x.Id))
                .ToList();
        }




        //public List<JobWithStatusDTO> GetJobsWithStatus(int userId)
        //{
        //    var appliedJobIds = _context.JobApplications
        //        .Where(x => x.UserId == userId)
        //        .Select(x => x.JobId)
        //        .ToList();

        //    return _context.Jobs.Select(job => new JobWithStatusDTO
        //    {
        //        Id = job.Id,
        //        Title = job.Title,
        //        Company = job.Company,
        //        IsApplied = appliedJobIds.Contains(job.Id)
        //    }).ToList();
        //}
    }
}