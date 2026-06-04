using Microsoft.EntityFrameworkCore;
using AutoMapper;
using JobProvider_App.DTO;
using JobProvider_App.Model;
namespace JobProvider_App.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<JobProvider, JobProviderDTO>().ReverseMap();

            CreateMap<Job, JobDTO>().ReverseMap();

            //CreateMap<JobProvider, JobProviderDTO>().ReverseMap();
            //CreateMap<Job, JobDTO>().ReverseMap();
        }
    }
}
