using Domain.Models;
using Domain.Services.Authuser.DTOs;
using Domain.Services.Profile.DTOs;

namespace Domain.Services.Profile.Interface
{
    public interface IJobSeekerProfileRepository
    {
        Task AddProfileAsync(JobSeekerProfile profile);

        Task AddSkillsToProfile(JobSeekerProfile profile);
        Task AddSkillsToProfile(Skill skill);
        Task AddWorkExperienceToProfile(Guid profileId, WorkExperience experience);

        Task AddQualificationsToProfile(Guid profileId, Qualification qualification);

        Task<JobSeekerProfile?> GetJobSeekerProfileByIds(Guid jobseekerId, Guid profileId);

        Task<JobSeekerProfile> GetProfileAsync(Guid jobSeekerId);

        Task<JobSeekerProfile?> GetProfileDetailAsync(Guid profileId);

        Task<List<JobSeekerProfile>> GetProfilesByJobSeekerIdAsync(Guid jobSeekerId);

        List<JobSeekerProfileDto> GetProfile(Guid jobseekerId);

        List<SkillDto> GetSkillsForProfile(Guid jobseekerId, Guid profileId);

        List<Skill> GetSkillsForProfile();
        Task<AuthUserDTO> UpdateProfile(AuthUserDTO updatedProfile);
        Task<List<Skill>> GetSkillsByIds(List<Guid> skillIds);
        List<WorkExperience> GetExperience(Guid jobseekerId, Guid profileId);

        List<Qualification> GetQualification(Guid profileId);
    }
}