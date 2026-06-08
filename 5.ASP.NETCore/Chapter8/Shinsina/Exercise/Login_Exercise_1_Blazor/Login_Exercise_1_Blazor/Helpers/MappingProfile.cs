using AutoMapper;
using Login_Exercise_1_Blazor.DTO;
using Login_Exercise_1_Blazor.Model;

namespace Login_Exercise_1_Blazor.Helpers
{
    public class MappingProfile:Profile
    {
        public  MappingProfile()
        {
            CreateMap<Seeker, SeekerRegisterDTO>().ReverseMap();
            //CreateMap<Job , LoginDTO>().ReverseMap();

        }
    }
}
