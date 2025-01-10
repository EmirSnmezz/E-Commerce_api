using DataAccess.Migrations;
using Entity.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = EMIRSNMEZ; Integrated Security = True; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = True; Application Intent = ReadWrite; Multi Subnet Failover = False");

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
