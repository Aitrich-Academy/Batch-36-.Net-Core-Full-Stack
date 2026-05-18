using Microsoft.EntityFrameworkCore;

namespace Library_Managment_MechineTest.Model
{
    public class AppDbContext:DbContext
    { 
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
       public DbSet<Book>Books { get; set; }
        public DbSet<AppUser> Users { get; set; }
    }
}
