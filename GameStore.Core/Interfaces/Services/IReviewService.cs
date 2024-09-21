using GameStore.DataAccess.Postgres.Models;

namespace GameStore.Core.Interfaces.Services
{
    public interface IReviewService : IService<ReviewEntity>
    {
        Task<IEnumerable<ReviewEntity>> GetReviewsByGameIdAsync(Guid gameId);
        Task<IEnumerable<ReviewEntity>> GetReviewsByUserIdAsync(Guid userId);
    }
}