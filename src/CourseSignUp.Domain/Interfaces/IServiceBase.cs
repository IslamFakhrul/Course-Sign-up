using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CourseSignUp.Domain.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
