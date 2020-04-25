using Microsoft.EntityFrameworkCore;
using Orderkeeper.Domain.Entities;
using OrderKeeper.Infrastructure.Data.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderKeeper.Infrastructure.Data.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemEntityConfiguration());
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Customer> Customers{get;set;}
        public DbSet<Product> Products  {get;set;}
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
