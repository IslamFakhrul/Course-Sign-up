using CourseSignUp.Domain.Interfaces;
using CourseSignUp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignUp.Domain.Services
{
    public class StudentService : ServiceBase<Student>, IStudentService
    {
        private readonly CourseSignUpDbContext _courseSignUpDbContext;

        public StudentService(CourseSignUpDbContext courseSignUpDbContext) 
            : base(courseSignUpDbContext)
        {
            _courseSignUpDbContext = courseSignUpDbContext;
        }

        public async Task<int> AddAsync(Student student)
        {
            var newStudent = new Student
            {
                Name = student.Name,
                Email = student.Email,
                DateOfBirth = student.DateOfBirth,
                Age = CalculateAge(student.DateOfBirth)
            };

            await _courseSignUpDbContext.Students.AddAsync(newStudent);

            await _courseSignUpDbContext.SaveChangesAsync();

            return newStudent.Id;
        }

        private int CalculateAge(DateTime dateOfBirth) => DateTime.Today.Year - dateOfBirth.Year;
    }
}
