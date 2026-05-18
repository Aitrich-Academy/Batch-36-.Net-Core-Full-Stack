using AutoMapper;
using JobPortal.DTO;
using JobPortal.Model;

namespace JobPortal.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Job, JobDTO>().ReverseMap();//mapping model class and DTO
        }
        
    }
}
