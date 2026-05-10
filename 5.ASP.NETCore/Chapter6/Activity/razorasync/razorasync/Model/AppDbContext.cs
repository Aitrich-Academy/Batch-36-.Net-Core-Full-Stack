using Microsoft.EntityFrameworkCore;
namespace razorasync.Model
{
    public class AppDbContext:DbContext
    {
       
            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options) { }

            public DbSet<Tour> Tours { get; set; }
        
    }
}
