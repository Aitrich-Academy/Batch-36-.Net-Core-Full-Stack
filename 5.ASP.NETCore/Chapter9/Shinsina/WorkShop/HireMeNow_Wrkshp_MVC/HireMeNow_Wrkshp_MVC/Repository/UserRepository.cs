using HireMeNow_Wrkshp_MVC.Dtos;
using HireMeNow_Wrkshp_MVC.Interface;
using HireMeNow_Wrkshp_MVC.Models;

namespace HireMeNow_Wrkshp_MVC.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly HireMeNowContext _context;

        public UserRepository(HireMeNowContext context)
        {
            _context = context;
        }

        public User Login(string email, string password)
        {
            return _context.Users
                    .FirstOrDefault(x => x.Email == email &&
                                       x.Password == password);
        }

        public void Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public User LoginJobSeeker(LoginDto dto)
        {
            return _context.Users.FirstOrDefault(u =>
                u.Email == dto.Email &&
                u.Password == dto.Password);
        }
        public void AddCompany(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }
    }
}
