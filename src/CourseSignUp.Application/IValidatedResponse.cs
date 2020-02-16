using FluentValidation.Results;

namespace CourseSignUp.Application
{
    public interface IValidatedResponse
    {
        ValidationResult ValidationResult { get; set; }
    }
}
