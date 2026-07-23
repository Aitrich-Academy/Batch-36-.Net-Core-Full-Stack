using Microsoft.EntityFrameworkCore;

namespace JWT_Activity_API.Models
{
    public class UserDbContext:DbContext
    {
        
        public UserDbContext(DbContextOptions<UserDbContext> options)
      : base(options) { }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
