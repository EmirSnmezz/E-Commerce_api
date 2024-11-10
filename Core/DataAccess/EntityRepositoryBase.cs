
using DataAccess.Abstract;
using Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EntityRepositoryBase<T, TContext> : IEntityRepository<T> 
        where T : class, IEntity, new()
        where TContext:  DbContext, new()
    {
        public void Add(T entity)
        {
            using (TContext context = new TContext())
            {
                EntityEntry addedEntity = context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (TContext context = new TContext())
            {
                EntityEntry deletedEntity = context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().FirstOrDefault(filter);
                
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>>? filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (TContext context = new TContext())
            {
                EntityEntry updatedEntity = context.Set<T>().Update(entity);
                context.SaveChanges();
            }
        }
    }
}
