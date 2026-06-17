using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HireMeNow_MVC_Exc.Models;

public partial class HireMeNowContext : DbContext
{
    public HireMeNowContext()
    {
    }

    public HireMeNowContext(DbContextOptions<HireMeNowContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Job> Jobs { get; set; }
    //public  DbSet<SavedJob> SavedJobs { get; set; }
    public virtual DbSet<JobApplication> JobApplications { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-SVQOJLE;Initial Catalog=HireMeNow_MVC_Exc;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK__Jobs__056690C2C00310AB");

            entity.Property(e => e.JobId).ValueGeneratedNever();
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.JobTitle).HasMaxLength(200);
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.PostedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<JobApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__JobAppli__C93A4C997846A465");

            entity.Property(e => e.ApplicationId).ValueGeneratedNever();
            entity.Property(e => e.AppliedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Job).WithMany(p => p.JobApplications)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobApplic__JobId__5441852A");

            entity.HasOne(d => d.User).WithMany(p => p.JobApplications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobApplic__UserI__534D60F1");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4CF0524CE9");

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534B96260D8").IsUnique();

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.UserRole).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
