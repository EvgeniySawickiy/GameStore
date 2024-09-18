using GameStore.DataAccess.Postgres.Models;

namespace GameStore.Core.Interfaces.Repositories
{
    public interface IGameRepository : IRepository<GameEntity>
    {

        Task<IEnumerable<GameEntity>> GetGamesByCategoryAsync(Guid categoryId);
        Task<IEnumerable<GameEntity>> GetTopRatedGamesAsync(int topCount);
        Task<IEnumerable<GameEntity>> SearchGamesAsync(string searchTerm);
    }
}
