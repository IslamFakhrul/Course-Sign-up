using FluentValidation.Results;

namespace CourseSignUp.Application.Commands.SignUpToCourse
{
    public class SignUpToCourseCommandResponse : IValidatedResponse
    {
        public ValidationResult ValidationResult { get; set; }

        public string Message { get; set; }
    }
}
