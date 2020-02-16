using FluentValidation;

namespace CourseSignUp.Application.Commands.Courses.CreateCourse
{
    public class CreateCourseCommandValidator : AbstractValidator<CreateCourseCommand>
    {
        public CreateCourseCommandValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;
        }
    }
}
