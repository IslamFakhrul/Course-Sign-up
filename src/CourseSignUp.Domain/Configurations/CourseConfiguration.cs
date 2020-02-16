using CourseSignUp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignUp.Domain.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Capacity)
                .IsRequired();

            builder.Property(c => c.LecturerId)
                .IsRequired();

            builder.Property(c => c.MinimumAge);

            builder.Property(c => c.MaximumAge);

            builder.Property(c => c.AverageAge)
                .HasColumnType("decimal(18,2)"); ;

            builder.HasOne(c => c.Lecturer)
                .WithMany(l => l.Courses)
                .HasForeignKey(d => d.LecturerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Course_Lecturer");
        }
    }
}
