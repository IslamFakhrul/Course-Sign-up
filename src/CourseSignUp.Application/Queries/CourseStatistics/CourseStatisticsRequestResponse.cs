namespace CourseSignUp.Application.Queries.CourseStatistics
{
    public class CourseStatisticsRequestResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinimumAge { get; set; }
        public int MaximumAge { get; set; }
        public decimal AverageAge { get; set; }
    }
}
