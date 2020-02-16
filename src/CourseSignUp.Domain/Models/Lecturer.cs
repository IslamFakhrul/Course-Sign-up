using System.Collections.Generic;

namespace CourseSignUp.Domain.Models
{
    public class Lecturer: Entity
    {
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }

        public Lecturer()
        {
            Courses = new HashSet<Course>();
        }
    }
}
