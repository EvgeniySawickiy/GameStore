using GameStore.DataAccess.Postgres.Models;

namespace GameStore.Core.Interfaces.Repositories
{
    public interface IReviewRepository : IRepository<ReviewEntity>
    {
        Task<IEnumerable<ReviewEntity>> GetReviewsByGameIdAsync(Guid gameId);
        Task<IEnumerable<ReviewEntity>> GetReviewsByUserIdAsync(Guid userId);
    }
}