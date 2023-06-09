using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Organization.Repository
{
    public interface IRepository<T> where T : class
    {
        public IQueryable<T> GetAll { get; }
        public IQueryable<T?> GetByExpression(Expression<Func<T, bool>> expression);
        public Task<T> Create(T entity);
        public Task<T> Update(T entity);
        public Task Delete(T entity);
    }
}