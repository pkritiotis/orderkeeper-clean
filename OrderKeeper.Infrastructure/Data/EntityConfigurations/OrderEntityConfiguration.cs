using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OrderKeeper.Infrastructure.Data.EntityConfigurations
{
    class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasMany(t => t.OrderItems)
                .WithOne(t => t.Order)
                .IsRequired();
            builder.HasOne(x => x.Customer)
                    .WithMany(x => x.Orders)
                    .IsRequired();
        }
    }
}