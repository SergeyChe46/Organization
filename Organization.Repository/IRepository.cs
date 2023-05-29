using System.Linq.Expressions;

namespace Organization.Repository
{
    public interface IRepository<T>
    {
        public IQueryable<T> GetAll { get; }
        public IQueryable<T?> GetByExpression(Expression<Func<T, bool>> expression);
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}