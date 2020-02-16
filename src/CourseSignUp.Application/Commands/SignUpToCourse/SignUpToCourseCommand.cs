using MediatR;
using System;

namespace CourseSignUp.Application.Commands.SignUpToCourse
{
    public class SignUpToCourseCommand: IRequest<SignUpToCourseCommandResponse>
    {
        public int CourseId { get; set; }

        public Student Student { get; set; }
    }

    public class Student
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
