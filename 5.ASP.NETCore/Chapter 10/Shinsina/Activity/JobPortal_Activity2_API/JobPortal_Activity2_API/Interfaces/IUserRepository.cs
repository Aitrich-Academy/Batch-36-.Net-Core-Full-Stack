using JobPortal_Activity2_API.Models;

namespace JobPortal_Activity2_API.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<User> RegisterAsync(User user);
        Task<User> GetUserByIdAsync(int id);

    }
}
