using Job_Portal_RazorExce.Model;

namespace Job_Portal_RazorExce.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();

        
        //void Register(User user);
        Task Register(User user);
        Task<User> Login(string email, string password);
      
        //User Login(string email, string password);
        User GetByEmail(string email);
       
    }
}

