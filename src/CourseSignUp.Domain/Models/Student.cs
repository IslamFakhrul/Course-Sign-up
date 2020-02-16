using System;
using System.Collections.Generic;

namespace CourseSignUp.Domain.Models
{
    public class Student: Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public ICollection<CourseStudent> CourseStudent { get; set; }

        public Student()
        {
            CourseStudent = new HashSet<CourseStudent>();
        }
    }
}
