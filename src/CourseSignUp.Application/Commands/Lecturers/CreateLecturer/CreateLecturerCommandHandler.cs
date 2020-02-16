using CourseSignUp.Domain.Interfaces;
using FluentValidation;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Application.Commands.Lecturers.CreateLecturer
{
    public class CreateLecturerCommandHandler : IRequestHandler<CreateLecturerCommand, int>
    {
        private readonly ILecturerService _lecturerService;

        private readonly IValidator<CreateLecturerCommand> _validator;

        public CreateLecturerCommandHandler(ILecturerService lecturerService, IValidator<CreateLecturerCommand> validator)
        {
            _lecturerService = lecturerService;
            _validator = validator;
        }

        public async Task<int> Handle(CreateLecturerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}