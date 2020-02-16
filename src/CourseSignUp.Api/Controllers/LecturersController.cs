using CourseSignUp.Application.Commands.Lecturers.CreateLecturer;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    [ApiController]
    public class LecturersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LecturersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost, Route("create")]
        public async Task<IActionResult> CreateAsync([FromBody]CreateLecturerCommand createLecturer)
        {
            return Ok(await _mediator.Send(createLecturer));
        }
    }
}