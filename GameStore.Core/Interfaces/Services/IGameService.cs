using GameStore.DataAccess.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Core.Interfaces.Services
{
    public interface IGameService : IService<GameEntity>
    {
        Task<IEnumerable<GameEntity>> GetGamesByCategoryAsync(Guid categoryId);
        Task<IEnumerable<GameEntity>> GetTopRatedGamesAsync(int topCount);
        Task<IEnumerable<GameEntity>> SearchGamesAsync(string searchTerm);
    }
}