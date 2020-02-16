using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace CourseSignUp.Application.Queries.CourseStatistics
{
    public class CourseStatisticsRequest : IRequest<CourseStatisticsRequestResponse>
    {
        public int Id { get; set; }
    }
}
