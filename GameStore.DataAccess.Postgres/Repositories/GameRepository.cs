using GameStore.Core.Interfaces.Repositories;
using GameStore.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DataAccess.Postgres.Repositories
{
    public class GameRepository : Repository<GameEntity>, IGameRepository
    {
        public GameRepository(GameStoreDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<GameEntity>> GetGamesByCategoryAsync(Guid categoryId)
        {
            return await _context.Games
                .Where(g => g.GameCategories.FirstOrDefault(c => c.Id == categoryId).Id == categoryId)
            .ToListAsync();
        }

        public async Task<IEnumerable<GameEntity>> GetTopRatedGamesAsync(int topCount)
        {
            return await _context.Games
                                 .OrderByDescending(g => g.Reviews.Where(r => r.Rating > 3))
                                 .Take(topCount)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<GameEntity>> SearchGamesAsync(string searchTerm)
        {
            return await _context.Games
                                 .Where(g => g.Title.Contains(searchTerm))
                                 .ToListAsync();
        }
    }
}