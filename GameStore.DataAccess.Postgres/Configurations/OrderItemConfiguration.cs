using GameStore.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GameStore.DataAccess.Postgres.Configurations
{
    internal class OrderItemConfiguration : IEntityTypeConfiguration<OrderItemEntity>
    {
        public void Configure(EntityTypeBuilder<OrderItemEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(o => o.Order)
                .WithMany(o => o.OrderItems);

            builder
                .HasOne(o => o.Game)
                .WithMany(g => g.OrderItems);
        }
    }
}
