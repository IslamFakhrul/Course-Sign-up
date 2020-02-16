using CourseSignUp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignUp.Domain.Interfaces
{
    public interface ICourseService : IServiceBase<Course>
    {
        Task<IEnumerable<Course>> GetAllAsync();

        Task<Course> GetByIdAsync(int id);

        Task SignUpAsync(int courseId, Student student);
    }
}