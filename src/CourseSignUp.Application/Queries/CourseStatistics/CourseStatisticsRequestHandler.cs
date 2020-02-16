using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CourseSignUp.Domain.Interfaces;
using MediatR;

namespace CourseSignUp.Application.Queries.CourseStatistics
{
    public class CourseStatisticsRequestHandler: IRequestHandler<CourseStatisticsRequest, CourseStatisticsRequestResponse>
    {
        private readonly ICourseService _courseService;

        public CourseStatisticsRequestHandler(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public async Task<CourseStatisticsRequestResponse> Handle(CourseStatisticsRequest request, CancellationToken cancellationToken)
        {
           var course = await _courseService.GetByIdAsync(request.Id);

            return new CourseStatisticsRequestResponse
            {
                Name = course.Name,
                Id = course.Id,
                MinimumAge = course.MinimumAge,
                MaximumAge = course.MaximumAge,
                AverageAge = course.AverageAge
            };
        }
    }
}
