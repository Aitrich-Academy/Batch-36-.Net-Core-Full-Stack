using AutoMapper;
using Job_Portal_RazorExce.DTO;
using Job_Portal_RazorExce.Model;

namespace Job_Portal_RazorExce.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDTO>().ReverseMap();

            CreateMap<JobApplication, JobApplicationDTO>().ReverseMap();
        }
    }
}
