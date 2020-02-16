using CourseSignUp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CourseSignUp.Domain.Services
{
    public class ServiceBase<TEntity> 
        : IServiceBase<TEntity> where TEntity : class
    {
        private readonly CourseSignUpDbContext _courseSignUpDbContext;

        public ServiceBase(CourseSignUpDbContext courseSignUpDbContext)
        {
            _courseSignUpDbContext = courseSignUpDbContext;
        }

        public void Add(TEntity entity)
        {
            _courseSignUpDbContext.Add(entity);
        }

        public TEntity GetById(int id)
        {
            return _courseSignUpDbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _courseSignUpDbContext.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _courseSignUpDbContext.Set<TEntity>().Where(predicate);
        }

        public void Update(TEntity entity)
        {
            _courseSignUpDbContext.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _courseSignUpDbContext.Remove(entity);
        }
    }
}
