using JobProvider_App.Interface;
using JobProvider_App.Model;
using JobProviderApp.Data;
using Microsoft.EntityFrameworkCore;
namespace JobProvider_App.Repository
{
    public class JobProviderRepository : IJobProviderRepository
    {
        private readonly AppDBContext _context;

        public JobProviderRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<JobProvider> GetByEmailAsync(string email)
        {
            return await _context.JobProviders.FirstOrDefaultAsync(jp => jp.Email == email);
        }

        public async Task AddAsync(JobProvider jobProvider)
        {
            _context.JobProviders.Add(jobProvider);
            await _context.SaveChangesAsync();
        }
    }
}
