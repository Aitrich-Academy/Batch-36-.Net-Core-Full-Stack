using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Services.Authuser.DTOs;
using Domain.Services.Profile.DTOs;
using Domain.Services.Profile.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Services.Profile
{
    public class ProfileService:IJobSeekerProfileService
    {
        public readonly IJobSeekerProfileRepository _profileRepository;
        IMapper _mapper;
        public ProfileService(IJobSeekerProfileRepository profileRepository, IMapper mapper)
        {
            _mapper = mapper;
            _profileRepository = profileRepository;
        }

        public async Task<bool> AddProfileAsync(ProfileDto addProfileDto)
        {
            var profile = _mapper.Map<JobSeekerProfile>(addProfileDto);
            await _profileRepository.AddProfileAsync(profile);
            return true;
        }

        public void AddQualificationToProfile(Guid jobseekerId, Guid profileId, Qualification qualification)
        {
            var profile = _profileRepository.GetJobSeekerProfileByIds(jobseekerId, profileId);
            if (profile != null)
            {
                var Qualification = _mapper.Map<Qualification>(qualification);
                _profileRepository.AddQualificationsToProfile(profileId, Qualification);

            }
            else
            {
                throw new Exception("Profile not found");
            }
        }


        public async Task AddQualificationToProfileAsync(Guid jobseekerId,
                                                 Guid profileId,
                                                 JobseekerQualificationDto dto)
        {
            var profile = await _profileRepository.GetJobSeekerProfileByIds(jobseekerId, profileId);

            if (profile == null)
                throw new Exception("Profile not found");

            var qualification = _mapper.Map<Qualification>(dto);

            await _profileRepository.AddQualificationsToProfile(profileId, qualification);
        }

        public async Task AddSkillsToProfile(Guid jobseekerId, Guid profileId, List<Guid> skillIds)
        {
            var profile = await _profileRepository.GetJobSeekerProfileByIds(jobseekerId, profileId);

            if (profile == null)
                throw new Exception("Profile not found");

            var skills = await _profileRepository.GetSkillsByIds(skillIds);

            foreach (var skill in skills)
            {
                profile.Skills.Add(skill);
            }

            await _profileRepository.AddSkillsToProfile(profile);
        }


        public async Task AddWorkExpericeToProfileAsync(Guid jobseekerId, Guid profileId, JobseekerWorkExperienceDto data)
        {
            var profile = _profileRepository.GetJobSeekerProfileByIds(jobseekerId, profileId);
            if (profile != null)
            {
                var Experience = _mapper.Map<WorkExperience>(data);
                await _profileRepository.AddWorkExperienceToProfile(profileId, Experience);


            }



        }

        public async Task<JobSeekerProfileDto> GetcompleateProfile(Guid jobseekerId)
        {
            var jobSeekerProfile = await _profileRepository.GetProfileAsync(jobseekerId);

            if (jobSeekerProfile == null)
            {
                // Handle case when the profile is not found
                return null; // or throw an exception or handle it according to your application logic
            }

            var jobSeekerProfileDTO = new JobSeekerProfileDto
            {
                UserName = jobSeekerProfile.JobSeeker.UserName,
                FirstName = jobSeekerProfile.JobSeeker.FirstName,
                LastName = jobSeekerProfile.JobSeeker.LastName,
                Phone = jobSeekerProfile.JobSeeker.Phone,
                Email = jobSeekerProfile.JobSeeker.Email,
                Qualifications = jobSeekerProfile.Qualifications.ToList(),
                JobSeekerProfileSkills = jobSeekerProfile.Skills.ToList(),
                Role = jobSeekerProfile.JobSeeker.Role,

            };

            return jobSeekerProfileDTO;
        }

        public List<ExperienceDto> GetExperience(Guid jobseekerId, Guid profileId)
        {

            var workExperiences = _profileRepository.GetExperience(jobseekerId, profileId);
            var experienceDtos = _mapper.Map<List<ExperienceDto>>(workExperiences);

            return experienceDtos;

        }

        public List<JobSeekerProfileDto> GetProfile(Guid jobseekerId)
        {
            return _profileRepository.GetProfile(jobseekerId);
        }

        public Task<JobSeekerProfile> GetProfileAsync(Guid jobSeekerId)
        {
            return _profileRepository.GetProfileAsync(jobSeekerId);


        }

        public Task GetProfileDetailsAsync(Guid jobseekerId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<JobSeekerProfile>> GetProfilesByJobSeekerIdAsync(Guid jobSeekerId)
        {
            return await _profileRepository.GetProfilesByJobSeekerIdAsync(jobSeekerId);
        }

        public List<JobseekerQualificationDto> GetQualification(Guid profileId)
        {

            var Qualifications = _profileRepository.GetQualification(profileId);
            var QualificationDtos = _mapper.Map<List<JobseekerQualificationDto>>(Qualifications);

            return QualificationDtos;

        }

        public List<SkillDto> GetSkillsForJobSeekerProfile(Guid jobseekerId, Guid profileId)
        {
            return _profileRepository.GetSkillsForProfile(jobseekerId, profileId);
        }

        public List<SkillDto> GetSkillsForJobSeekerProfile()
        {
            var Skills = _profileRepository.GetSkillsForProfile();
            var SkillDtos = _mapper.Map<List<SkillDto>>(Skills);

            return SkillDtos;

        }


        public async Task<AuthUserDTO> UpdateProfile(AuthUserDTO updatedProfile)
        {
            return await _profileRepository.UpdateProfile(updatedProfile);
        }
    }
}
