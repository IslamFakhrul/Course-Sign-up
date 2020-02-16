using MediatR;

namespace CourseSignUp.Application.Commands.Lecturers.CreateLecturer
{
    public class CreateLecturerCommand: IRequest<int>
    {
        public string Name { get; set; }
    }
}
