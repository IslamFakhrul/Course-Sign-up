using CourseSignUp.Application.Queries.CoursesStatistics;
using CourseSignUp.Application.Queries.CourseStatistics;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetStatistics")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CoursesStatisticsRequestResponse>> GetAsync()

        {
            return Ok(await _mediator.Send(new CoursesStatisticsRequest()));
        }

        [HttpGet("{id:int}", Name = "GetStatisticsById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CourseStatisticsRequestResponse>> GetByIdAsync(int id)
        {
            return Ok(await _mediator.Send(new CourseStatisticsRequest { Id = id }));
        }
    }
}