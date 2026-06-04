using Login_Exercise_1_Blazor.DTO;

namespace Login_Exercise_1_Blazor.Interface
{
    public interface ISeekerAuthService
    {
        Task<bool> Register(SeekerRegisterDTO seekerdto, string password);
        Task<bool> Login(string email, string password);
        Task<bool> Logout();
    }
}
