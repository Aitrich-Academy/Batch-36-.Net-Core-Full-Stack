using UserApplication.Model;
using Microsoft.EntityFrameworkCore;
using UserApplication.Interface;

namespace UserApplication.Repository
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
            _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
        public async Task<User> Login(string email, string password)
        {
            return await _context.Users
                .FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
        }

        public async Task<User> GetById(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
