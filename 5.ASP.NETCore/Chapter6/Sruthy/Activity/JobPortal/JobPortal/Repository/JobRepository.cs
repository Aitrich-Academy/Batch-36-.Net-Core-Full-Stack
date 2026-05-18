using JobPortal.Interface;
using JobPortal.Model;
using AutoMapper;
using JobPortal.DTO;
using Microsoft.EntityFrameworkCore;
namespace JobPortal.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public JobRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        
        public async Task<IEnumerable<Job>> GetAllAsync()
        {
            return await _context.Job.ToListAsync();

        }
        public async Task<Job> GetByIdAsync(int id) 
        {
            return await _context.Job.FindAsync(id);
        }
        public async Task AddAsync(Job job) 
        {
            await _context.Job.AddAsync(job);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Job job) 
        {
           _context.Job.Update(job);
            await _context.SaveChangesAsync();


        }
        public async Task DeleteAsync(int id) 
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
