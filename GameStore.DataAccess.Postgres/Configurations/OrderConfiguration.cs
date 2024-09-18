using GameStore.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.DataAccess.Postgres.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(o => o.Id);

            builder
                .HasOne(o => o.User)
                .WithMany(u => u.Orders);

            builder
                .HasMany(o => o.OrderItems)
                .WithOne(o => o.Order)
                .HasForeignKey(o => o.OrderId);

            builder
                .HasMany(o => o.Payments)
                .WithOne(p => p.Order)
                .HasForeignKey(p=>p.OrderId);
        }
    }
}
