using JobPortal_Activity2_API.DTOs;

namespace JobPortal_Activity2_API.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> RegisterUserAsync(RegisterDTO registerDto);
        Task<UserDTO> LoginUserAsync(LoginDTO loginDto);
        Task<UserDTO> GetUserByIdAsync(int Id);
    }
}
