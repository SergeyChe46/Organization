using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Organization.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext context;
        public BaseRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IQueryable<T> GetAll => context.Set<T>()
            .AsNoTracking();

        public void Create(T entity)
        {
            context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetByExpression(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }
    }
}