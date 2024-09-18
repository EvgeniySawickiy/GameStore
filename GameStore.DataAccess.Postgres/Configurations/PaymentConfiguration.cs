using GameStore.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.DataAccess.Postgres.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<PaymentEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentEntity> builder)
        {
           builder.HasKey(x => x.Id);

            builder
                .HasOne(p => p.Order)
                .WithMany(o => o.Payments);
        }
    }
}
