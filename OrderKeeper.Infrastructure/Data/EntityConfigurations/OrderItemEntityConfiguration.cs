using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderKeeper.Infrastructure.Data.EntityConfigurations
{
    class OrderItemEntityConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasOne(t => t.Order)
                    .WithMany(t => t.OrderItems)
                    .IsRequired();
            builder.HasOne(t => t.Product)
                    .WithMany(t => t.OrderItems)
                    .IsRequired();

        }
    }
}