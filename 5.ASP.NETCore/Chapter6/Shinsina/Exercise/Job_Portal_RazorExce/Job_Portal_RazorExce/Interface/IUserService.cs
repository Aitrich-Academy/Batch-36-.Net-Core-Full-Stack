using Job_Portal_RazorExce.Model;

namespace Job_Portal_RazorExce.Interface
{
    
        public interface IUserService
        {
            Task<List<User>> GetUsers();

            Task Register(User user);
            Task<User> Login(string email, string password);
    }
    }

