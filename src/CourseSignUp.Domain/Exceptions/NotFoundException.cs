using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException()
        : this("Entity not found")
        {
        }

        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }

        public NotFoundException(string message) : base(message)
        {
        }
    }
}
