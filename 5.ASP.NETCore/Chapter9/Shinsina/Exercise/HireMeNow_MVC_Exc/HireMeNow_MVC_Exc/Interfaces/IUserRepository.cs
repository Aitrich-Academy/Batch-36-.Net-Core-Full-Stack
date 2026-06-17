using HireMeNow_MVC_Exc.Models;

namespace HireMeNow_MVC_Exc.Interfaces
{
    public interface IUserRepository
    {

        Task RegisterAsync(User user);

        Task<User?> LoginAsync(string email,string password);

        Task<User?> GetUserAsync(Guid userId);

        Task UpdateAsync(User user);
    }
}
