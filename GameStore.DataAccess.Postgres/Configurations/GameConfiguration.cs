using GameStore.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;


namespace GameStore.DataAccess.Postgres.Configurations
{
    internal class GameConfiguration : IEntityTypeConfiguration<GameEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<GameEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder
                .HasMany(g => g.GameCategories)
                .WithMany(c => c.GamesInCategory);

            builder
                .HasMany(g => g.Reviews)
                .WithOne(r => r.Game)
                .HasForeignKey(r=>r.GameId);

            builder
                .HasMany(g => g.OrderItems)
                .WithOne(o => o.Game)
                .HasForeignKey(o => o.GameId);
        }
    }
}
