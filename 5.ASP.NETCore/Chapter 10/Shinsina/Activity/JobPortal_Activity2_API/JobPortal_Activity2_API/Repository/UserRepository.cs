using JobPortal_Activity2_API.Interfaces;
using JobPortal_Activity2_API.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal_Activity2_API.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<User> RegisterAsync(User user) 
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
        public async Task<User> GetUserByIdAsync(int Id) 
        {
            return await _context.Users.FindAsync(Id);
        }
    }
}
