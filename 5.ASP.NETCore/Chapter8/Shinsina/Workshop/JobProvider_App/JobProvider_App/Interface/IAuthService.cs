using JobProvider_App.DTO;

namespace JobProvider_App.Interface
{
    public interface IAuthService
    {
        Task<bool> Register(JobProviderDTO jobProviderDTO, string password);
        Task<bool> Login(string email, string password);
        Task Logout();
    }
}
