using GameStore.Core.Interfaces.Repositories;
using GameStore.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.DataAccess.Postgres.Repositories
{
    public class ReviewRepository : Repository<ReviewEntity>, IReviewRepository
    {
        public ReviewRepository(GameStoreDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ReviewEntity>> GetReviewsByGameIdAsync(Guid gameId)
        {
            return await _context.Reviews
                                 .Where(r => r.GameId == gameId)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<ReviewEntity>> GetReviewsByUserIdAsync(Guid userId)
        {
            return await _context.Reviews
                                 .Where(r => r.UserId == userId)
                                 .ToListAsync();
        }
    }
}