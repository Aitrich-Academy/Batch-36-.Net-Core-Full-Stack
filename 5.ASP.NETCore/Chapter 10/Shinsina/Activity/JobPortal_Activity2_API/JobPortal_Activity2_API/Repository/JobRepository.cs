using JobPortal_Activity2_API.Interfaces;
using JobPortal_Activity2_API.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal_Activity2_API.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly ApplicationDbContext _context;

        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Job>> GetJobsAsync()
        {
            return await _context.Jobs.ToListAsync();
        }
        public async Task<Job> GetJobByIdAsync(int Id)
        {
            return await _context.Jobs.FindAsync(Id);
        }
        public async Task<Job> AddJobAsync(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
            return job;
        }
        public async Task<Job> UpdateJobAsync(Job job) 
        {
            _context.Jobs.Update(job);
            await _context.SaveChangesAsync();
            return job;
        }
        public async Task<bool> DeleteJobAsync(int Id) {
            var dltjob = await _context.Jobs.FindAsync(Id);
            if (dltjob == null)
                return false;
            _context.Jobs.Remove(dltjob);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
