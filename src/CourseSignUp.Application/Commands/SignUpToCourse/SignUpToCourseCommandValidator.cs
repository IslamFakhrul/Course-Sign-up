using FluentValidation;
using System;

namespace CourseSignUp.Application.Commands.SignUpToCourse
{
    public class SignUpToCourseCommandValidator : AbstractValidator<SignUpToCourseCommand>
    {
        public SignUpToCourseCommandValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(x => x.CourseId)
                .NotEmpty().WithMessage("CourseId is required.");

            RuleFor(x => x.Student)
                .NotNull().WithMessage("Student is required.");

            RuleFor(x => x.Student.Name)
                .NotEmpty().WithMessage("Student name is required.");

            RuleFor(x => x.Student.Email)
                .NotEmpty().WithMessage("Student email is required.");

            RuleFor(x => x.Student.DateOfBirth)
                .NotEmpty().WithMessage("Student date of birth is required.")
                .Must(BeAValidDate).WithMessage("Date of birth must be valid date");
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default);
        }
    }
}
