using CourseSignUp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignUp.Domain.Configurations
{
    public class CourseStudentConfiguration : IEntityTypeConfiguration<CourseStudent>
    {
        public void Configure(EntityTypeBuilder<CourseStudent> builder)
        {
            builder.ToTable("CourseStudent");

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.CourseId)
                .IsRequired();

            builder.Property(x => x.StudentId)
                .IsRequired();

            builder.HasOne(x => x.Course)
                .WithMany(p => p.CourseStudent)
                .HasForeignKey(x => x.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CourseStudent_Course");

            builder.HasOne(x => x.Student)
                .WithMany(p => p.CourseStudent)
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CourseStudent_Student");
        }
    }
}