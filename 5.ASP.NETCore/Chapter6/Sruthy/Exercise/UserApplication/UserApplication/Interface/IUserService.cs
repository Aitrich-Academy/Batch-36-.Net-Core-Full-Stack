using UserApplication.Dto;

namespace UserApplication.Interface
{
    public interface IUserService
    {
        Task<UserDto> Login(string email, string password);
        Task Register(UserDto userDto);
        Task<UserDto> GetUserById(int id);
    }
}
