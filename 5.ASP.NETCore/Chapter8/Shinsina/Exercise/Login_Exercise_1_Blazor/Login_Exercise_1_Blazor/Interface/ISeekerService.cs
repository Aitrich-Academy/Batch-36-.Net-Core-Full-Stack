using Login_Exercise_1_Blazor.DTO;
using Login_Exercise_1_Blazor.Model;

namespace Login_Exercise_1_Blazor.Interface
{
    public interface ISeekerService
    {
        Task RegisterAsync(SeekerRegisterDTO dto);

        Task<Seeker?> LoginAsync(LoginDTO dto);

        //Task<ProfileDTO?> GetProfileAsync(int id);

        //Task UpdateProfileAsync(ProfileDTO dto);
    }
}
