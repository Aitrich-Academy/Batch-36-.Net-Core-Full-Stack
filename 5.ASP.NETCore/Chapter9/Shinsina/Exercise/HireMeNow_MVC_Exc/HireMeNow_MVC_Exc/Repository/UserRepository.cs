using HireMeNow_MVC_Exc.Interfaces;
using HireMeNow_MVC_Exc.Models;
using Microsoft.EntityFrameworkCore;

namespace HireMeNow_MVC_Exc.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly HireMeNowContext _context;
        public UserRepository(HireMeNowContext context)
        {
            _context = context;
        }

        public async Task RegisterAsync(User user) 
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User?> LoginAsync(string email, string password) 
        {
          return await _context.Users.FirstOrDefaultAsync(x=>x.Email == email && x.Password == password);
        }

        public async Task<User?> GetUserAsync(Guid userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
