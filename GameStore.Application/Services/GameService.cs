
using GameStore.Core.Interfaces.Repositories;
using GameStore.Core.Interfaces.Services;
using GameStore.DataAccess.Postgres.Models;

namespace GameStore.Application.Services
{
    public class GameService : Service<GameEntity>, IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository) : base(gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<IEnumerable<GameEntity>> GetGamesByCategoryAsync(int categoryId)
        {
            return await _gameRepository.GetGamesByCategoryAsync(categoryId);
        }

        public async Task<IEnumerable<GameEntity>> GetTopRatedGamesAsync(int topCount)
        {
            return await _gameRepository.GetTopRatedGamesAsync(topCount);
        }

        public async Task<IEnumerable<GameEntity>> SearchGamesAsync(string searchTerm)
        {
            return await _gameRepository.SearchGamesAsync(searchTerm);
        }
    }
}