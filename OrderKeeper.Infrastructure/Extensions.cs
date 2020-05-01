using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using Orderkeeper.Infrastructure;
using OrderKeeper.Infrastructure.Data.AppDbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderKeeper.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            
            services.AddScoped<IRepository<Customer>, CustomerRepository>();
            services.AddScoped<IRepository<Product>, ProductRepository>();
            services.AddScoped<IRepository<Order>, OrderRepository>();
            return services;
        }
    }
}
