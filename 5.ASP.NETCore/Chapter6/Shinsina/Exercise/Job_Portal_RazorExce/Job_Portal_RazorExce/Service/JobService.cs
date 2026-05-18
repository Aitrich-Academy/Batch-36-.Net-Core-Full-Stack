using AutoMapper;
using Job_Portal_RazorExce.DTO;
using Job_Portal_RazorExce.Interface;
using Job_Portal_RazorExce.Model;
using Microsoft.EntityFrameworkCore;

namespace Job_Portal_RazorExce.Service
{
    public class JobService : IJobService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public JobService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<JobDTO> GetJobs(int userId)
        {
            var appliedJobIds = _context.JobApplications
                .Where(x => x.UserId == userId)
                .Select(x => x.JobId)
                .ToList();

            var jobs = _context.Jobs.ToList();

            var jobDtos = _mapper.Map<List<JobDTO>>(jobs);

            foreach (var job in jobDtos)
            {
                job.IsApplied = appliedJobIds.Contains(job.Id);
            }

            return jobDtos;
        }

        public void ApplyJob(JobApplicationDTO dto)
        {
            var application = _mapper.Map<JobApplication>(dto);

            _context.JobApplications.Add(application);

            _context.SaveChanges();
        }

        public List<JobDTO> GetAppliedJobs(int userId)
        {
            var jobIds = _context.JobApplications
                .Where(x => x.UserId == userId)
                .Select(x => x.JobId)
                .ToList();

            var jobs = _context.Jobs
                .Where(x => jobIds.Contains(x.Id))
                .ToList();

            return _mapper.Map<List<JobDTO>>(jobs);
        }
    }
}
        //private readonly AppDbContext _context;

        //public JobService(AppDbContext context)
        //{
        //    _context = context;
        //}

        //public List<Job> GetJobs()
        //{
        //    return _context.Jobs.ToList();
        //}

        //public void ApplyJob(int userId, int jobId)
        //{
        //    _context.JobApplications.Add(new JobApplication
        //    {
        //        UserId = userId,
        //        JobId = jobId
        //    });

        //    _context.SaveChanges();
        //}

        //public List<Job> GetAppliedJobs(int userId)
        //{
        //    var jobIds = _context.JobApplications
        //        .Where(x => x.UserId == userId)
        //        .Select(x => x.JobId)
        //        .ToList();

        //    return _context.Jobs
        //        .Where(x => jobIds.Contains(x.Id))
        //        .ToList();
        //}
    

