using AutoMapper;
using JobPortalManagment.DTO;
using JobPortalManagment.Migrations.Model;

namespace JobPortalManagment.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            //CreateMap<JobDTO, Job>();

            //CreateMap<Job, JobDTO>();

            CreateMap<Job, JobDTO>().ReverseMap();
        }
    }
}
