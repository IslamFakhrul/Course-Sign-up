using CourseSignUp.Domain.Models;
using System.Collections.Generic;

namespace CourseSignUp.Application.Queries.CoursesStatistics
{
    public class CoursesStatisticsRequestResponse
    {
       public IEnumerable<Course> CourseStatistics { get; set; }
    }
}
