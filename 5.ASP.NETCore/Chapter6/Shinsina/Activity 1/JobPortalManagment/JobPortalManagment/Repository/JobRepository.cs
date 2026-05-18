using JobPortalManagment.Interface;
using JobPortalManagment.Migrations.Model;
using Microsoft.EntityFrameworkCore;

namespace JobPortalManagment.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly AppDbContext _context;
        public JobRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddJob(Job job) 
        {
            await _context.Job.AddAsync(job);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Job>> GetAllJobs()
        {
            return await _context.Job.ToListAsync();
        }
        public async Task<Job> GetJobById(int id)
        {
            return await _context.Job.FindAsync(id);
        }

        public async Task UpdateJob(Job job)
        {
            _context.Job.Update(job);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteJob(int id)
        {
            var job = await _context.Job.FindAsync(id);

            if (job != null)
            {
                _context.Job.Remove(job);
                await _context.SaveChangesAsync();
            }
        }
    }
}
