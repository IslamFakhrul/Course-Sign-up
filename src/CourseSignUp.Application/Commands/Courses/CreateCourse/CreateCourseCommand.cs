using MediatR;

namespace CourseSignUp.Application.Commands.Courses.CreateCourse
{
    public class CreateCourseCommand: IRequest<int>
    {
        public string LecturerId { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }
    }
}
