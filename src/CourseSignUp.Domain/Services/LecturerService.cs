using CourseSignUp.Domain.Interfaces;
using CourseSignUp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Services
{
    public class LecturerService : ServiceBase<Lecturer>, ILecturerService
    {
        public LecturerService(CourseSignUpDbContext courseSignUpDbContext) : base(courseSignUpDbContext)
        {
        }
    }
}