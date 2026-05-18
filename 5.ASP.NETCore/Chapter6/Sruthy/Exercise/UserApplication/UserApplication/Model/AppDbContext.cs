using Microsoft.EntityFrameworkCore;

namespace UserApplication.Model
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
        public DbSet<User> Users { get; set; }
        public DbSet<CompanyMember> CompanyMember { get; set; }
    }
}
