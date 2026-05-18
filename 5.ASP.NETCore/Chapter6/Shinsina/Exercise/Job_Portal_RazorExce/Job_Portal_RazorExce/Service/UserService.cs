using Job_Portal_RazorExce.Interface;
using Job_Portal_RazorExce.Model;
using static Job_Portal_RazorExce.Service.UserService;

namespace Job_Portal_RazorExce.Service
{
        public class UserService : IUserService
        {
            private readonly IUserRepository _repo;

            public UserService(IUserRepository repo)
            {
                _repo = repo;
            }
        public async Task<List<User>> GetUsers()
        {
            return await _repo.GetUsers();
        }
        //public async Task<List<User>> GetUsers()
        //    {
        //        return await _repo.GetUsers();
        //    }

            public async Task Register(User user)
            {
                await _repo.Register(user);
            }
            public async Task<User> Login(string email, string password)
            {
                return await _repo.Login(email, password);
            }
        }
    }

