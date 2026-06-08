using Login_Exercise_1_Blazor.Model;

namespace Login_Exercise_1_Blazor.Interface
{
    public interface ISeekerRepository
    {
        Task RegisterAsync(Seeker seeker);

        Task<Seeker?> LoginAsync(string email, string password);

        Task<Seeker?> GetByIdAsync(int id);

        //Task UpdateAsync(Seeker seeker);
    }
}
