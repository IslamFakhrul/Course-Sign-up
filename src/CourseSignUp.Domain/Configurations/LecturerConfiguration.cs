using CourseSignUp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignUp.Domain.Configurations
{
    public class LecturerConfiguration : IEntityTypeConfiguration<Lecturer>
    {
        public void Configure(EntityTypeBuilder<Lecturer> builder)
        {
            builder.ToTable("Lecturer");

            builder.Property(l => l.Id)
                .HasColumnName("Id");

            builder.Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}