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
        public IQueryable<T?> GetByCondition(Expression<Func<T, bool>> expression);
        public Task<T> Create(T newData);
        public Task<T> Update(T editedData);
        public Task Delete(T deletedData);
    }
}