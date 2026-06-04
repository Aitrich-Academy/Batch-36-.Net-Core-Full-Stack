using JobProvider_App.Interface;
using JobProvider_App.Model;
using JobProviderApp.Data;
using Microsoft.EntityFrameworkCore;

namespace JobProvider_App.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDBContext _context; 

        public JobRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<Job>> GetJobsByProviderIdAsync(int providerId)
        {
            return await _context.Jobs.Where(j => j.JobProviderId == providerId).ToListAsync();
        }

        public async Task<Job> GetByIdAsync(int jobId)
        {
            return await _context.Jobs.FindAsync(jobId);
        }

        public async Task AddAsync(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Job job)
        {
            _context.Jobs.Update(job);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int jobId)
        {
            var job = await _context.Jobs.FindAsync(jobId);
            if (job != null)
            {
                _context.Jobs.Remove(job);
                await _context.SaveChangesAsync();
            }
        }
    }
}
