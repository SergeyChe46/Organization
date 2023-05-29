using System.Linq.Expressions;

namespace Organization.Repository
{
    public interface IRepository<T>
    {
        public IQueryable<T> GetAll { get; }
        public IQueryable<T?> GetByExpression(Expression<Func<T, bool>> expression);
        public Task<T> Create(T entity);
        public Task<T> Update(T entity);
        public Task Delete(T entity);
    }
}