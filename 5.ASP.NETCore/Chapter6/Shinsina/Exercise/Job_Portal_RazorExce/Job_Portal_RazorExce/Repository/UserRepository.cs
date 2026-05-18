using Job_Portal_RazorExce.Interface;
using Job_Portal_RazorExce.Model;
using Job_Portal_RazorExce.DTO;
using Microsoft.EntityFrameworkCore;

namespace Job_Portal_RazorExce.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Register(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> Login(string email, string password)
        {
            return await _context.Users
                .FirstOrDefaultAsync(x =>
                    x.Email == email &&
                    x.Password == password);
        }

        public User GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }
        public async Task< List<User>> GetUsers()
        {
            return _context.Users.ToList();
        }
        //public async Task<List<User>> GetUsers()
        //{
        //    return await _context.Users.ToListAsync();
        //}
    }
}
