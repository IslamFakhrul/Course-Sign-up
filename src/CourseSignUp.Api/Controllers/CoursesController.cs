using CourseSignUp.Application.Commands.Courses.CreateCourse;
using CourseSignUp.Application.Commands.SignUpToCourse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CoursesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost, Route("create")]
        public async Task<IActionResult> CreateAsync([FromBody]CreateCourseCommand createCourse)
        {
            return Ok(await _mediator.Send(createCourse));
        }

        [HttpPost, Route("sign-up")]
        [ProducesDefaultResponseType(typeof(SignUpToCourseCommandResponse))]
        public async Task<IActionResult> SignUpAsync([FromBody] SignUpToCourseCommand signUpToCourse)
        {
            return Ok(await _mediator.Send(signUpToCourse));
        }

    }
}