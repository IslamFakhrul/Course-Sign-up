using CourseSignUp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignUp.Domain.Interfaces
{
   public interface IStudentService : IServiceBase<Student>
    {
        Task<int> AddAsync(Student student);
    }
}
