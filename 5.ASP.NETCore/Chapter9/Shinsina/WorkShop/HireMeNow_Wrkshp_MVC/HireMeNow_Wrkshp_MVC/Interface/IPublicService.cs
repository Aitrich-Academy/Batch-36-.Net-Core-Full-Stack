using Microsoft.EntityFrameworkCore;
using HireMeNow_Wrkshp_MVC.Dtos;
using HireMeNow_Wrkshp_MVC.Models;

    namespace HireMeNow_Wrkshp_MVC.Interface
{
    public interface IPublicService
    {
        bool Register(RegisterDto dto);

        User LoginJobSeeker(LoginDto dto);
    }
}
