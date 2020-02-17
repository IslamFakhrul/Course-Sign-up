using CourseSignUp.Domain.Interfaces;
using FluentValidation;
using Hangfire;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Application.Commands.SignUpToCourse
{
    public class SignUpToCourseCommandHandler : IRequestHandler<SignUpToCourseCommand, SignUpToCourseCommandResponse>
    {
        private readonly ICourseService _courseService;

        private readonly IValidator<SignUpToCourseCommand> _validator;

        public SignUpToCourseCommandHandler(ICourseService courseService, IValidator<SignUpToCourseCommand> validator)
        {
            _courseService = courseService;
            _validator = validator;
        }

        public async Task<SignUpToCourseCommandResponse> Handle(SignUpToCourseCommand request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            if (!validationResult.IsValid)
            {
                return new SignUpToCourseCommandResponse
                {
                    ValidationResult = validationResult
                };
            }

            var student = new Domain.Models.Student
            {
                Name = request.Student.Name,
                Email = request.Student.Email,
                DateOfBirth = request.Student.DateOfBirth
            };

            BackgroundJob.Enqueue<ICourseService>(x => x.SignUpAsync(request.CourseId, student));

            return new SignUpToCourseCommandResponse
            {
                Message = "Thank you for your interest. We have receveid your request and you will receive an email later."
            };
        }
    }
}