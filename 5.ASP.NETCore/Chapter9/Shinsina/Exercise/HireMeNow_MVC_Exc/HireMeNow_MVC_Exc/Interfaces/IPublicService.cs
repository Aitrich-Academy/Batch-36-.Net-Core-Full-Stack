using HireMeNow_MVC_Exc.DTOs;
using HireMeNow_MVC_Exc.Models;

namespace HireMeNow_MVC_Exc.Interfaces
{
    public interface IPublicService
    {
        Task RegisterAsync(RegisterDto registerDto);

        Task<User?> LoginAsync(LoginDto dto);
    }
}
