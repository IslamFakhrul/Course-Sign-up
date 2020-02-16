using FluentValidation;

namespace CourseSignUp.Application.Commands.Lecturers.CreateLecturer
{
    public class CreateLecturerCommandValidator : AbstractValidator<CreateLecturerCommand>
    {
        public CreateLecturerCommandValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;
        }
    }
}
