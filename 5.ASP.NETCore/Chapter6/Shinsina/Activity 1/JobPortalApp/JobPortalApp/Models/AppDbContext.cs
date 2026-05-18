using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace JobPortalApp.Models
{
    public class AppDbContext:DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(" Data Source=DESKTOP-SVQOJLE;Initial Catalog=HireMeNowDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
