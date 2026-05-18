using Microsoft.EntityFrameworkCore;

namespace Workshop_1.Model
{
    public class AppDbContext : DbContext
    {
        internal object Student;
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}