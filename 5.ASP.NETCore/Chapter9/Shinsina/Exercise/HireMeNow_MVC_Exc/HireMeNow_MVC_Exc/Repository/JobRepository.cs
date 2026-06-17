using HireMeNow_MVC_Exc.Interfaces;
using HireMeNow_MVC_Exc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Linq;

namespace HireMeNow_MVC_Exc.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly HireMeNowContext _context;

        public JobRepository(HireMeNowContext context)
        {
            _context = context;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job?> GetJobAsync(Guid jobId)
        {
            return await _context.Jobs
                .FirstOrDefaultAsync(x =>
                    x.JobId == jobId);
        }
        //Task SaveJobAsync(
        //   SavedJob savedJob);

        //Task<List<SavedJob>> GetSavedJobsAsync(
        //    Guid userId);
      
        public async Task ApplyJobAsync( JobApplication application)
        { 
            await _context.JobApplications.AddAsync(application);
            await _context.SaveChangesAsync();
        }
        public async Task<List<JobApplication>> GetApplicationsByUserAsync(Guid userId)
        {
            return await _context.JobApplications
                .Include(a => a.Job)
                .Where(a => a.UserId == userId)
                .ToListAsync();
        }
        public async Task AddApplicationAsync(JobApplication application)
        {
            _context.JobApplications.Add(application);
            await _context.SaveChangesAsync();
        }

        public async Task<List<JobApplication>> GetAppliedJobsByUserAsync(Guid userId)
        {
            return await _context.JobApplications
                .Include(a => a.Job)
                .Where(a => a.UserId == userId)
                .ToListAsync();
        }
    }
}
