using Login_Exercise_1_Blazor.Interface;
using Login_Exercise_1_Blazor.Model;
using Microsoft.EntityFrameworkCore;

namespace Login_Exercise_1_Blazor.Repository
{

    //public class JobRepository : IJobRepository
    //{

    //private static List<Job> jobs = new()
    //{
    //    new Job
    //    {
    //        ID = 1,
    //        Title = "Software Developer",
    //        Description = "ASP.NET Core Developer",
    //        Location = "Kochi",
    //        Salary = 500000,
    //        JobType = "Full Time",
    //        SeekerID = 0
    //    },
    //    new Job
    //    {
    //        ID = 2,
    //        Title = "Angular Developer",
    //        Description = "Frontend Developer",
    //        Location = "Bangalore",
    //        Salary = 450000,
    //        JobType = "Full Time",
    //        SeekerID = 0
    //    },
    //    new Job
    //    {
    //        ID = 3,
    //        Title = "Tester",
    //        Description = "Core Developer",
    //        Location = "Kochi",
    //        Salary = 6000,
    //        JobType = "Full Time",
    //        SeekerID = 0
    //    },
    //};
    //public async Task<List<Job>> GetAllJobsAsync()
    //{
    //    return await Task.FromResult(jobs);
    //}
    public class JobRepository : IJobRepository
    {
        private readonly AppDBContext _context;

        public JobRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task AddJobAsync(Job job)
        {
            await _context.Jobs.AddAsync(job);

            await _context.SaveChangesAsync();
        }

    }
}
