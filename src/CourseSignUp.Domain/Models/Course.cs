using System.Collections.Generic;

namespace CourseSignUp.Domain.Models
{
    public class Course: Entity
    {
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int LecturerId { get; set; }

        public int MinimumAge { get; set; }

        public int MaximumAge { get; set; }

        public decimal AverageAge { get; set; }

        public Lecturer Lecturer { get; set; }

        public ICollection<CourseStudent> CourseStudent { get; set; }

        public Course()
        {
            CourseStudent = new HashSet<CourseStudent>();
        }

    }
}
