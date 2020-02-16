using CourseSignUp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseSignUp.Domain
{
    public class CourseSignUpDbContext : DbContext
    {
        public CourseSignUpDbContext()
        {
        }

        public CourseSignUpDbContext(DbContextOptions<CourseSignUpDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Lecturer> Lecturers { get; set; }

        public DbSet<CourseStudent> CourseStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseSignUpDbContext).Assembly);
        }
    }
}
