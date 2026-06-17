using HireMeNow_MVC_Exc.DTOs;
using HireMeNow_MVC_Exc.Models;

public interface IJobSeekerService
{
    Task<User?> GetProfileAsync(Guid userId);

    Task UpdateProfileAsync(ProfileDto dto);

    Task<List<Job>> GetAllJobsAsync();

    Task<bool> ApplyJobAsync(Guid userId, Guid jobId);

    Task<List<JobApplication>> GetMyApplicationsAsync(Guid userId);

    Task DeleteApplicationAsync(Guid applicationId);
}
