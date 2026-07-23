using Domain.Models;
using Domain.Services.Authuser.DTOs;
using Domain.Services.Profile.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Profile.Interface
{
    internal interface IJobSeekerProfileService
    {
        Task<bool> AddProfileAsync(ProfileDto addProfileDto);
        Task AddQualificationToProfileAsync(Guid jobseekerId, Guid profileId, JobseekerQualificationDto jobseekerQualificationDTo);

        Task AddSkillsToProfile(Guid jobseekerId, Guid profileId, List<Guid> skills);

        Task AddWorkExpericeToProfileAsync(Guid jobseekerId, Guid profileId, JobseekerWorkExperienceDto jobseekerWorkExperienceDTo);
       
        List<ExperienceDto> GetExperience(Guid jobseekerId, Guid profileId);
        List<JobSeekerProfileDto> GetProfile(Guid jobseekerId);
        Task<AuthUserDTO> UpdateProfile(AuthUserDTO updatedProfile);
        
        Task<JobSeekerProfile> GetProfileAsync(Guid jobSeekerId);
        Task GetProfileDetailsAsync(Guid jobseekerId);
        Task<List<JobSeekerProfile>> GetProfilesByJobSeekerIdAsync(Guid jobSeekerId);
        List<JobseekerQualificationDto> GetQualification(Guid profileId);
        List<SkillDto> GetSkillsForJobSeekerProfile(Guid jobseekerId, Guid profileId);
        List<SkillDto> GetSkillsForJobSeekerProfile();
        Task<JobSeekerProfileDto> GetcompleateProfile(Guid jobseekerId);
        //Task<AuthUserDTO> UpdateJobSeekerProfile(AuthUserDTO updatedProfile);
    }
}
