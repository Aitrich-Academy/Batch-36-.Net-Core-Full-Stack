using Microsoft.EntityFrameworkCore;
namespace Auth_Blazor.Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
