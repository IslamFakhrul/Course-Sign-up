using CourseSignUp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignUp.Domain.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");

            builder.Property(s => s.Id)
                .HasColumnName("Id");

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(s => s.DateOfBirth)
                .IsRequired();

            builder.Property(s => s.Age)
                .IsRequired();
        }
    }
}
