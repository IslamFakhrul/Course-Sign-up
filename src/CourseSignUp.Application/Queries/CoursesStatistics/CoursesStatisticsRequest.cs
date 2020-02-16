using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CourseSignUp.Application.Queries.CoursesStatistics
{
    public class CoursesStatisticsRequest : IRequest<CoursesStatisticsRequestResponse>
    {
       //Can be add property for paging to get Courses Statistics by paging
    }
}
