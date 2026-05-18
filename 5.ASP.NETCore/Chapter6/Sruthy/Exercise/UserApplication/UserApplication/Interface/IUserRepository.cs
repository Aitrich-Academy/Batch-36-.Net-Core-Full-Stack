using UserApplication.Model;
using UserApplication.Dto;

namespace UserApplication.Interface
{
    public interface IUserRepository
    {
        Task<User> Login(string email, string password);
        Task Register(User user);
        Task<User> GetById(int id);
    }
}
