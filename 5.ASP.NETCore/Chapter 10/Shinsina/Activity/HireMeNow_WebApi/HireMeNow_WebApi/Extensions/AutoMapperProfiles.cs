using AutoMapper;
using Domain.Models;
using Domain.Services.Job.DTOs;
using Domain.Services.Login.DTOs;
using Domain.Services.Job.DTOs;
using Domain.Services.Profile.DTOs;
using Domain.Services.Admin.DTOs;
using Domain.Services.Job.DTOs;
using Domain.Services.Login.DTOs;
using HireMeNow_WebApi.API.Admin.RequestObjects;

namespace HireMeNow_WebApi.Extensions
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {


            //CreateMap<SignUpRequest, SystemUser>().ReverseMap();
            CreateMap<AuthUser, Domain.Models.JobSeeker>().ReverseMap();
            CreateMap<AuthUser, SystemUser>().ReverseMap();
            CreateMap<AuthUser, Domain.Models.CompanyUser>().ReverseMap();
            CreateMap<JobPost, JobPostsDtos>().ReverseMap();
            CreateMap<JobPost, Domain.Services.Admin.DTOs.JobProviderDto>().ReverseMap();


            CreateMap<Skill, SkillDto>();
            CreateMap<JobseekerQualificationDto, Qualification>();

            CreateMap<JobseekerWorkExperienceDto, WorkExperience>();
            CreateMap<WorkExperience, ExperienceDto>();
            CreateMap<AuthUser, JobSeekerLoginDto>();
            CreateMap<Industry, IndustryRequest>().ReverseMap();
            CreateMap<JobCategory, CategoryRequest>().ReverseMap();
            CreateMap<Location, LocationRequest>().ReverseMap();
            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<JobProviderCompany, Domain.Services.Admin.DTOs.JobProviderDto>().ReverseMap();


            CreateMap<AuthUser, JobSeekerLoginDto>();
            CreateMap<JobPost, JobList>().ReverseMap();
            CreateMap<AuthUser, AdminLoginDTO>();

            CreateMap<JobSeekerProfileDto, Domain.Models.JobSeeker>();


            CreateMap<JobPost, JobPostsDtos>().ReverseMap();
            CreateMap<JobPost, Domain.Services.Admin.DTOs.JobProviderDto>().ReverseMap();
            CreateMap<Domain.Models.JobSeeker, JobSeekerDto>().ReverseMap();
            CreateMap<JobProviderCompany, Domain.Services.Admin.DTOs.JobProviderDto>().ReverseMap();

            CreateMap<JobSeekerProfile, ProfileDto>();

            CreateMap<ProfileDto, JobSeekerProfile>();
            CreateMap<SkillRequest, SkillDto>();
            CreateMap<SkillDto, Skill>();

        }
    }
}
