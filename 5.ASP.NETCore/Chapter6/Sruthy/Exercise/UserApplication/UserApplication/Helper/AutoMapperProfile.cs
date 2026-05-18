using AutoMapper;
using UserApplication.Dto;
using UserApplication.Model;

namespace UserApplication.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<CompanyMember,  CompanyMemberDto>().ReverseMap();
        }
        
    }
}
