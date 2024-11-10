using DataAccess.Abstract;
using Entity.Abstract;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EntityRepositoryBase<T> : IEntityRepository<T> where T : class, IEntity, new()
    {
        public void Add(T entity)
        {
            using (NorthwindDbContext context = new NorthwindDbContext())
            {
                EntityEntry addedEntity = context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (NorthwindDbContext context = new NorthwindDbContext())
            {
                EntityEntry deletedEntity = context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (NorthwindDbContext context = new NorthwindDbContext())
            {
                return context.Set<T>().FirstOrDefault(filter)
                
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>>? filter = null)
        {
            using (NorthwindDbContext context = new NorthwindDbContext())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (NorthwindDbContext context = new NorthwindDbContext())
            {
                EntityEntry updatedEntity = context.Set<T>().Update(entity);
                context.SaveChanges();
            }
        }
    }
}
