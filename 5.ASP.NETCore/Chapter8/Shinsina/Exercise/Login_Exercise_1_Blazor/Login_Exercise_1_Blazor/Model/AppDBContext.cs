using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Login_Exercise_1_Blazor.Model
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) { }
        public DbSet<Seeker> Seekers { get; set; }
        public DbSet <Job> Jobs { get; set; }

    }
}
