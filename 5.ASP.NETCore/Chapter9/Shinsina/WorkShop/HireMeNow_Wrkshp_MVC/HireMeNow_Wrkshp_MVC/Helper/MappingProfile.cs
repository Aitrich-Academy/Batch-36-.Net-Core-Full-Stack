using AutoMapper;
using HireMeNow_Wrkshp_MVC.Dtos;
using HireMeNow_Wrkshp_MVC.Models;

namespace HireMeNow_Wrkshp_MVC.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<JobDto, Job>().ReverseMap();

            CreateMap<UserDto, User>().ReverseMap();

            CreateMap<CompanyMemberDto, User>().ReverseMap();
        }
    }
}
