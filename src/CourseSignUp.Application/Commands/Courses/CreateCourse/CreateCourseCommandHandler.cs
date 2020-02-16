using CourseSignUp.Domain.Interfaces;
using FluentValidation;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Application.Commands.Courses.CreateCourse
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, int>
    {
        private readonly ICourseService _courseService;

        private readonly IValidator<CreateCourseCommand> _validator;

        public CreateCourseCommandHandler(ICourseService courseService, IValidator<CreateCourseCommand> validator)
        {
            _courseService = courseService;
            _validator = validator;
        }

        public async Task<int> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}