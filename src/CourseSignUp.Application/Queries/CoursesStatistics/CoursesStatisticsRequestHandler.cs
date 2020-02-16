using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CourseSignUp.Domain.Interfaces;
using MediatR;

namespace CourseSignUp.Application.Queries.CoursesStatistics
{
    public class CoursesStatisticsRequestHandler : IRequestHandler<CoursesStatisticsRequest, CoursesStatisticsRequestResponse>
    {
        private readonly ICourseService _courseService;

        public CoursesStatisticsRequestHandler(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public async Task<CoursesStatisticsRequestResponse> Handle(CoursesStatisticsRequest request, CancellationToken cancellationToken)
        {
            var courses = await _courseService.GetAllAsync();

            return new CoursesStatisticsRequestResponse
            {
                CourseStatistics = courses
            };
        }
    }
}
