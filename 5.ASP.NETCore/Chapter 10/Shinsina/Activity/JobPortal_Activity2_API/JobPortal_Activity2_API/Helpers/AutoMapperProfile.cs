using AutoMapper;
using JobPortal_Activity2_API.DTOs;
using JobPortal_Activity2_API.Models;

namespace JobPortal_Activity2_API.Helpers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Job, JobDTO>().ReverseMap();
        }
       
    }
}
