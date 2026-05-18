using AutoMapper;
using JobManagement.Model;
using JobManagement.Dto;

namespace JobManagement.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Jobs, JobDto>().ReverseMap();
        }
    }
}
