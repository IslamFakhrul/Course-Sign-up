using CourseSignUp.Domain.Exceptions;
using CourseSignUp.Domain.Interfaces;
using CourseSignUp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignUp.Domain.Services
{
    public class CourseService : ServiceBase<Course>, ICourseService
    {
        private readonly CourseSignUpDbContext _courseSignUpDbContext;

        private readonly IStudentService _studentService;

        public CourseService(CourseSignUpDbContext courseSignUpDbContext, IStudentService studentService)
            : base(courseSignUpDbContext)
        {
            _courseSignUpDbContext = courseSignUpDbContext;
            _studentService = studentService;
        }

        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await _courseSignUpDbContext.Courses
                .Include(x => x.Lecturer)
                .Include(x => x.CourseStudent)
                .ToListAsync();
        }

        public async Task<Course> GetByIdAsync(int id)
        {
            return await _courseSignUpDbContext.Courses
                .Include(x => x.Lecturer)
                .Include(x => x.CourseStudent)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task SignUpAsync(int courseId, Student student)
        {
            var existingCourse = await GetByIdAsync(courseId);

            if (existingCourse == null)
            {
                throw new NotFoundException("The course does not exists");
            }

            if (existingCourse.CourseStudent.Count == existingCourse.Capacity)
            {
                throw new Exception("The selected course is full.");
            }

            //Add Student
            var studentId = await _studentService.AddAsync(student);

            var courseStudent = new CourseStudent
            {
                CourseId = courseId,
                StudentId = studentId
            };

            existingCourse.CourseStudent.Add(courseStudent);

            await _courseSignUpDbContext.SaveChangesAsync();

            await UpdateCourseStatistics(courseId);
        }

        private async Task UpdateCourseStatistics(int courseId)
        {
            var existingCourse = await GetByIdAsync(courseId);

            var firstStudent = existingCourse.CourseStudent.FirstOrDefault();

            var maximumAge = firstStudent.Student.Age;
            var minimumAge = firstStudent.Student.Age;
            var totalAges = 0;

            foreach (var courseStudent in existingCourse.CourseStudent)
            {
                if (courseStudent.Student.Age < minimumAge)
                {
                    minimumAge = courseStudent.Student.Age;
                }

                if (courseStudent.Student.Age > maximumAge)
                {
                    maximumAge = courseStudent.Student.Age;
                }

                totalAges += courseStudent.Student.Age;
            }

            var averageAge = totalAges / existingCourse.CourseStudent.Count();

            existingCourse.AverageAge = averageAge;
            existingCourse.MaximumAge = maximumAge;
            existingCourse.MinimumAge = minimumAge;

            await _courseSignUpDbContext.SaveChangesAsync();
        }
    }
}