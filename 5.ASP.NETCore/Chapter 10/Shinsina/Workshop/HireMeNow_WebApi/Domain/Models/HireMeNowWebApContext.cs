using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public partial class HireMeNowWebApContext : DbContext
{
    public HireMeNowWebApContext()
    {
    }

    public HireMeNowWebApContext(DbContextOptions<HireMeNowWebApContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuthUser> AuthUsers { get; set; }

    public virtual DbSet<CompanyUser> CompanyUsers { get; set; }

    public virtual DbSet<GroupMember> GroupMembers { get; set; }

    public virtual DbSet<Industry> Industries { get; set; }

    public virtual DbSet<Interview> Interviews { get; set; }

    public virtual DbSet<JobApplication> JobApplications { get; set; }

    public virtual DbSet<JobCategory> JobCategories { get; set; }

    public virtual DbSet<JobPost> JobPosts { get; set; }

    public virtual DbSet<JobProviderCompany> JobProviderCompanies { get; set; }

    public virtual DbSet<JobResponsibility> JobResponsibilities { get; set; }

    public virtual DbSet<JobSeeker> JobSeekers { get; set; }

    public virtual DbSet<JobSeekerProfile> JobSeekerProfiles { get; set; }

    public virtual DbSet<JobSeekerProfileSkill> JobSeekerProfileSkills { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<MessageGroup> MessageGroups { get; set; }

    public virtual DbSet<Qualification> Qualifications { get; set; }

    public virtual DbSet<Resume> Resumes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SavedJob> SavedJobs { get; set; }

    public virtual DbSet<SignUpRequest> SignUpRequests { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<SystemUser> SystemUsers { get; set; }

    public virtual DbSet<WorkExperience> WorkExperiences { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-SVQOJLE;Initial Catalog=HireMeNow_WebAp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AuthUser__3214EC0755F3CF97");

            entity.ToTable("AuthUser");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConnectionId).HasMaxLength(200);
            entity.Property(e => e.OnlineStatus).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.AuthUser)
                .HasForeignKey<AuthUser>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuthUser_SystemUser");
        });

        modelBuilder.Entity<CompanyUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyU__3214EC072AB4762F");

            entity.ToTable("CompanyUser");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(100);

            entity.HasOne(d => d.CompanyNavigation).WithMany(p => p.CompanyUsers)
                .HasForeignKey(d => d.Company)
                .HasConstraintName("FK__CompanyUs__Compa__5FB337D6");
        });

        modelBuilder.Entity<GroupMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GroupMem__3214EC07D680F476");

            entity.ToTable("GroupMember");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.MessageGroup).WithMany(p => p.GroupMembers)
                .HasForeignKey(d => d.MessageGroupId)
                .HasConstraintName("FK__GroupMemb__Messa__1DB06A4F");
        });

        modelBuilder.Entity<Industry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Industry__3214EC070A0F16F9");

            entity.ToTable("Industry");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<Interview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Intervie__3214EC07E78DE058");

            entity.ToTable("Interview");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Application).WithMany(p => p.Interviews)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("FK__Interview__Appli__151B244E");

            entity.HasOne(d => d.Company).WithMany(p => p.Interviews)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Interview__Compa__17036CC0");

            entity.HasOne(d => d.IntervieweeNavigation).WithMany(p => p.Interviews)
                .HasForeignKey(d => d.Interviewee)
                .HasConstraintName("FK__Interview__Inter__14270015");

            entity.HasOne(d => d.Job).WithMany(p => p.Interviews)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__Interview__JobId__1332DBDC");

            entity.HasOne(d => d.SheduledByNavigation).WithMany(p => p.Interviews)
                .HasForeignKey(d => d.SheduledBy)
                .HasConstraintName("FK__Interview__Shedu__160F4887");
        });

        modelBuilder.Entity<JobApplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JobAppli__3214EC0778DD2319");

            entity.ToTable("JobApplication");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.JobPostId).HasColumnName("JobPost_id");
            entity.Property(e => e.ResumeId).HasColumnName("Resume_id");

            entity.HasOne(d => d.ApplicantNavigation).WithMany(p => p.JobApplications)
                .HasForeignKey(d => d.Applicant)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobApplic__Appli__0E6E26BF");

            entity.HasOne(d => d.JobPost).WithMany(p => p.JobApplications)
                .HasForeignKey(d => d.JobPostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobApplic__JobPo__0D7A0286");

            entity.HasOne(d => d.Resume).WithMany(p => p.JobApplications)
                .HasForeignKey(d => d.ResumeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobApplic__Resum__0F624AF8");
        });

        modelBuilder.Entity<JobCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JobCateg__3214EC07BD796C36");

            entity.ToTable("JobCategory");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<JobPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JobPost__3214EC0772787882");

            entity.ToTable("JobPost");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.JobTitle).HasMaxLength(200);

            entity.HasOne(d => d.Category).WithMany(p => p.JobPosts)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobPost__Categor__7D439ABD");

            entity.HasOne(d => d.Company).WithMany(p => p.JobPosts)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobPost__Company__7C4F7684");

            entity.HasOne(d => d.Industry).WithMany(p => p.JobPosts)
                .HasForeignKey(d => d.IndustryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobPost__Industr__7E37BEF6");

            entity.HasOne(d => d.Location).WithMany(p => p.JobPosts)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobPost__Locatio__7B5B524B");

            entity.HasOne(d => d.PostedByNavigation).WithMany(p => p.JobPosts)
                .HasForeignKey(d => d.PostedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobPost__PostedB__7F2BE32F");
        });

        modelBuilder.Entity<JobProviderCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JobProvi__3214EC0706E7E090");

            entity.ToTable("JobProviderCompany");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.LegalName).HasMaxLength(200);
            entity.Property(e => e.Website).HasMaxLength(300);

            entity.HasOne(d => d.Industry).WithMany(p => p.JobProviderCompanies)
                .HasForeignKey(d => d.IndustryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobProvid__Indus__5AEE82B9");

            entity.HasOne(d => d.LocationNavigation).WithMany(p => p.JobProviderCompanies)
                .HasForeignKey(d => d.Location)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobProvid__Locat__5BE2A6F2");
        });

        modelBuilder.Entity<JobResponsibility>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JobRespo__3214EC076BBFF19E");

            entity.ToTable("JobResponsibility");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.JobPostNavigation).WithMany(p => p.JobResponsibilities)
                .HasForeignKey(d => d.JobPost)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobRespon__JobPo__04E4BC85");
        });

        modelBuilder.Entity<JobSeeker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JobSeeke__3214EC07C0A11B18");

            entity.ToTable("JobSeeker");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<JobSeekerProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JobSeeke__3214EC070371EE9E");

            entity.ToTable("JobSeekerProfile");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ProfileName).HasMaxLength(200);

            entity.HasOne(d => d.JobSeeker).WithMany(p => p.JobSeekerProfiles)
                .HasForeignKey(d => d.JobSeekerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobSeeker__JobSe__6A30C649");

            entity.HasOne(d => d.Resume).WithMany(p => p.JobSeekerProfiles)
                .HasForeignKey(d => d.ResumeId)
                .HasConstraintName("FK__JobSeeker__Resum__693CA210");
        });

        modelBuilder.Entity<JobSeekerProfileSkill>(entity =>
        {
            entity.HasKey(e => new { e.JobSeekerProfileId, e.SkillId }).HasName("PK__JobSeeke__C66959E433859833");

            entity.ToTable("JobSeekerProfileSkill");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.JobSeekerProfile).WithMany(p => p.JobSeekerProfileSkills)
                .HasForeignKey(d => d.JobSeekerProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobSeeker__JobSe__6FE99F9F");

            entity.HasOne(d => d.Skill).WithMany(p => p.JobSeekerProfileSkills)
                .HasForeignKey(d => d.SkillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__JobSeeker__Skill__70DDC3D8");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Location__3214EC0700C6CF14");

            entity.ToTable("Location");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Message__3214EC07D049914B");

            entity.ToTable("Message");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.From).HasMaxLength(200);
            entity.Property(e => e.To).HasMaxLength(200);
            entity.Property(e => e.ToGroup).HasMaxLength(200);

            entity.HasOne(d => d.MessageGroup).WithMany(p => p.Messages)
                .HasForeignKey(d => d.MessageGroupId)
                .HasConstraintName("FK__Message__Message__2180FB33");
        });

        modelBuilder.Entity<MessageGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MessageG__3214EC07AAF2E15B");

            entity.ToTable("MessageGroup");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Qualification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Qualific__3214EC07C0ED0C2E");

            entity.ToTable("Qualification");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.JobPost).WithMany(p => p.Qualifications)
                .HasForeignKey(d => d.JobPostId)
                .HasConstraintName("FK_Qualification_JobPost");

            entity.HasOne(d => d.JobSeekerProfile).WithMany(p => p.Qualifications)
                .HasForeignKey(d => d.JobSeekerProfileId)
                .HasConstraintName("FK_Qualification_Profile");
        });

        modelBuilder.Entity<Resume>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Resume__3214EC07D4AC25B2");

            entity.ToTable("Resume");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Role__3214EC07FF9206E0");

            entity.ToTable("Role");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<SavedJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SavedJob__3214EC076E96828D");

            entity.ToTable("SavedJob");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.JobNavigation).WithMany(p => p.SavedJobs)
                .HasForeignKey(d => d.Job)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SavedJob__Job__08B54D69");

            entity.HasOne(d => d.SavedByNavigation).WithMany(p => p.SavedJobs)
                .HasForeignKey(d => d.SavedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SavedJob__SavedB__09A971A2");
        });

        modelBuilder.Entity<SignUpRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SignUpRe__3214EC07B583D7B7");

            entity.ToTable("SignUpRequest");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Skill__3214EC0760CC827F");

            entity.ToTable("Skill");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<SystemUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SystemUs__3214EC0741084E63");

            entity.ToTable("SystemUser");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<WorkExperience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WorkExpe__3214EC077DFF0907");

            entity.ToTable("WorkExperience");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.JobTitle).HasMaxLength(200);

            entity.HasOne(d => d.JobSeekerProfile).WithMany(p => p.WorkExperiences)
                .HasForeignKey(d => d.JobSeekerProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WorkExper__JobSe__778AC167");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
