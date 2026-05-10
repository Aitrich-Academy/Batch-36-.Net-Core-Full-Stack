using AutoMapper;
using razorasync.Dtos;
using razorasync.Model;

namespace razorasync.Helper
{
    public class AutoMapperProfile:Profile
    {
            public AutoMapperProfile()
            {
            CreateMap<Tour, TourDto>().ReverseMap();
        }
    }
}
