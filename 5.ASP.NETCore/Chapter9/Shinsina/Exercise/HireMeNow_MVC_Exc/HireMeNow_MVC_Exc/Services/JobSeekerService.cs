using HireMeNow_MVC_Exc.DTOs;
using HireMeNow_MVC_Exc.Interfaces;
using HireMeNow_MVC_Exc.Models;
using Microsoft.EntityFrameworkCore;

namespace HireMeNow_MVC_Exc.Services
{
    public class JobSeekerService : IJobSeekerService
    {
        private readonly IUserRepository _userRepo;
        private readonly IJobRepository _jobRepo;
        private readonly HireMeNowContext _context;

        public JobSeekerService(
            IUserRepository userRepo,
            IJobRepository jobRepo,
            HireMeNowContext context)
        {
            _userRepo = userRepo;
            _jobRepo = jobRepo;
            _context = context;
        }

        // ============================
        // PROFILE
        // ============================
        public async Task<User?> GetProfileAsync(Guid userId)
        {
            return await _userRepo.GetUserAsync(userId);
        }

        public async Task UpdateProfileAsync(ProfileDto dto)
        {
            var user = await _userRepo.GetUserAsync(dto.UserId);

            if (user == null) return;

            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.PhoneNumber = dto.PhoneNumber;

            await _userRepo.UpdateAsync(user);
        }

        // ============================
        // JOB LIST
        // ============================
        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _jobRepo.GetAllJobsAsync();
        }

        // ============================
        // APPLY JOB
        // ============================
        public async Task<bool> ApplyJobAsync(Guid userId, Guid jobId)
        {
            var alreadyApplied = await _context.JobApplications
                .AnyAsync(x => x.UserId == userId && x.JobId == jobId);

            if (alreadyApplied)
                return false;

            var application = new JobApplication
            {
                ApplicationId = Guid.NewGuid(),
                UserId = userId,
                JobId = jobId,
                AppliedDate = DateTime.UtcNow
            };

            await _context.JobApplications.AddAsync(application);
            await _context.SaveChangesAsync();

            return true;
        }

        // ============================
        // GET APPLIED JOBS
        // ============================
        public async Task<List<JobApplication>> GetMyApplicationsAsync(Guid userId)
        {
            return await _context.JobApplications
                .Include(x => x.Job)
                .Where(x => x.UserId == userId)
                .OrderByDescending(x => x.AppliedDate)
                .ToListAsync();
        }

        // ============================
        // DELETE APPLICATION
        // ============================
        public async Task DeleteApplicationAsync(Guid applicationId)
        {
            var app = await _context.JobApplications
                .FirstOrDefaultAsync(x => x.ApplicationId == applicationId);

            if (app == null) return;

            _context.JobApplications.Remove(app);
            await _context.SaveChangesAsync();
        }
    }
}