using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Data.Models;

namespace SchoolApi.Data
{
    public class DbContext : IdentityDbContext
    {
        public DbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Enrollments)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Enrollments)
                .WithOne(e => e.Teacher)
                .HasForeignKey(e => e.TeacherId);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Enrollments)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId);
        }
    }
}
