using Entity.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true ");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        //public override int SaveChanges()
        //{
        //    var entries = ChangeTracker.Entries<IEntity>().ToList();
        //    foreach (var entry in entries)
        //    {
        //        if(entry.State == EntityState.Added)
        //        {
        //            entry.Property(p => p.CreatedDate).CurrentValue = DateTime.Now;
        //        }

        //        if(entry.State == EntityState.Modified)
        //        {
        //            entry.Property(p => p.UpdatedDate).CurrentValue = DateTime.Now;
        //        }
        //    }
        //    return base.SaveChanges();
        //}
    }
}
