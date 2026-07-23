using Domain.Models;
using Domain.Services.Profile.DTOs;
using Domain.Services.Profile.Interface;
using Microsoft.EntityFrameworkCore;
using Domain.Services.Authuser.DTOs;

namespace Domain.Services.Profile
{
    public class JobSeekerProfileRepository : IJobSeekerProfileRepository
    {

        private readonly DbHireMeNowWebApiContext _context;


        public JobSeekerProfileRepository(
            DbHireMeNowWebApiContext context)
        {
            _context = context;
        }

        public async Task AddSkillsToProfile(JobSeekerProfile profile)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            _context.JobSeekerProfiles.Update(profile);
            await _context.SaveChangesAsync();
        }

        public async Task AddProfileAsync(JobSeekerProfile profile)
        {
            profile.Id = Guid.NewGuid();

            await _context.JobSeekerProfiles.AddAsync(profile);

            await _context.SaveChangesAsync();
        }



        public async Task AddSkillsToProfile(Skill skill)
        {
            skill.Id = Guid.NewGuid();

            await _context.Skills.AddAsync(skill);

            await _context.SaveChangesAsync();
        }




        public async Task AddWorkExperienceToProfile(
            Guid profileId,
            WorkExperience experience)
        {

            experience.Id = Guid.NewGuid();

            experience.JobSeekerProfileId = profileId;


            await _context.WorkExperiences.AddAsync(experience);


            await _context.SaveChangesAsync();

        }




        public async Task AddQualificationsToProfile(
            Guid profileId,
            Qualification qualification)
        {

            qualification.Id = Guid.NewGuid();

            qualification.JobseekerProfileId = profileId;


            await _context.Qualifications.AddAsync(qualification);


            await _context.SaveChangesAsync();

        }




        public async Task<JobSeekerProfile?> GetJobSeekerProfileByIds(
            Guid jobSeekerId,
            Guid profileId)
        {

            return await _context.JobSeekerProfiles

                .Include(x => x.JobSeeker)

                .Include(x => x.Resume)

                .Include(x => x.WorkExperiences)

                .Include(x => x.Skills)
                 .Include(x => x.Qualifications)

                .FirstOrDefaultAsync(x =>
                    x.JobSeekerId == jobSeekerId &&
                    x.Id == profileId);

        }





        public async Task<JobSeekerProfile?> GetProfileAsync(
            Guid jobSeekerId)
        {

            return await _context.JobSeekerProfiles

                .Include(x => x.JobSeeker)

                .Include(x => x.Resume)

                .Include(x => x.WorkExperiences)

                .Include(x => x.Skills)
                 .Include(x => x.Qualifications)

                .FirstOrDefaultAsync(x =>
                    x.JobSeekerId == jobSeekerId);

        }





        public async Task<JobSeekerProfile?> GetProfileDetailAsync(
            Guid profileId)
        {

            return await _context.JobSeekerProfiles

                .Include(x => x.JobSeeker)

                .Include(x => x.Resume)

                .Include(x => x.WorkExperiences)

                .Include(x => x.Skills)
                 .Include(x => x.Qualifications)

                .FirstOrDefaultAsync(x =>
                    x.Id == profileId);

        }


        public async Task<List<Skill>> GetSkillsByIds(List<Guid> skillIds)
        {
            return await _context.Skills
                .Where(s => skillIds.Contains(s.Id))
                .ToListAsync();
        }
        public async Task<AuthUserDTO> UpdateProfile(AuthUserDTO updatedProfile)
        {
            var user = await _context.AuthUsers
                .FirstOrDefaultAsync(x => x.Id == updatedProfile.JobseekerId);

            if (user == null)
                throw new Exception("User not found.");

            user.Name = updatedProfile.UserName;
            user.Email = updatedProfile.Email;

            await _context.SaveChangesAsync();

            return updatedProfile;
        }
        public async Task<List<JobSeekerProfile>> GetProfilesByJobSeekerIdAsync(
            Guid jobSeekerId)
        {

            return await _context.JobSeekerProfiles

                .Where(x => x.JobSeekerId == jobSeekerId)

                .Include(x => x.WorkExperiences)

                .Include(x => x.Skills)
                 .Include(x => x.Qualifications)

                .ToListAsync();

        }





        public List<SkillDto> GetSkillsForProfile(
            Guid jobSeekerId,
            Guid profileId)
        {

            return _context.Skills

                .Where(x =>
                    x.JobSeekerProfileId == profileId)

                .Select(x => new SkillDto
                {
                    Name = x.Name,
                    Description = x.Description

                })

                .ToList();

        }




        public List<Skill> GetSkillsForProfile()
        {

            return _context.Skills
                .ToList();

        }





        public List<WorkExperience> GetExperience(
            Guid jobSeekerId,
            Guid profileId)
        {

            return _context.WorkExperiences

                .Where(x =>
                    x.JobSeekerProfileId == profileId)

                .ToList();

        }




        public List<Qualification> GetQualification(
            Guid profileId)
        {

            return _context.Qualifications

                .Where(x =>
                    x.JobseekerProfileId == profileId)

                .ToList();

        }





        public List<JobSeekerProfileDto> GetProfile(
            Guid jobSeekerId)
        {

            var profile = _context.JobSeekerProfiles
     .Include(x => x.JobSeeker)
     .Include(x => x.Skills)
     .Include(x => x.Qualifications)
     .FirstOrDefault(x => x.JobSeekerId == jobSeekerId);



            if (profile == null)
                return new List<JobSeekerProfileDto>();



            var dto = new JobSeekerProfileDto
            {

                UserName = profile.JobSeeker.UserName,

                FirstName = profile.JobSeeker.FirstName,

                LastName = profile.JobSeeker.LastName,

                Phone = profile.JobSeeker.Phone,

                Email = profile.JobSeeker.Email,

                Role = profile.JobSeeker.Role,

                Qualifications = profile.Qualifications.ToList(),


                JobSeekerProfileSkills = profile.Skills.ToList()


            };


            return new List<JobSeekerProfileDto>
            {
                dto
            };

        }


    }
}