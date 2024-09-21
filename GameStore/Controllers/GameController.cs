using GameStore.Core.Interfaces.Services;
using GameStore.DataAccess.Postgres.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameEntity>>> GetAllGames()
        {
            var games = await _gameService.GetAllAsync();
            return Ok(games);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GameEntity>> GetGameById(Guid id)
        {
            var game = await _gameService.GetByIdAsync(id);
            if (game == null)
                return NotFound();

            return Ok(game);
        }

        [HttpPost]
        public async Task<IActionResult> AddGame([FromBody] GameEntity game)
        {
            await _gameService.AddAsync(game);
            return CreatedAtAction(nameof(GetGameById), new { id = game.Id }, game);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGame(Guid id, [FromBody] GameEntity game)
        {
            if (id != game.Id)
                return BadRequest();

            await _gameService.UpdateAsync(game);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(Guid id)
        {
            await _gameService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("category/{categoryId}")]
        public async Task<ActionResult<IEnumerable<GameEntity>>> GetGamesByCategory(Guid categoryId)
        {
            var games = await _gameService.GetGamesByCategoryAsync(categoryId);
            return Ok(games);
        }

        [HttpGet("top-rated/{topCount}")]
        public async Task<ActionResult<IEnumerable<GameEntity>>> GetTopRatedGames(int topCount)
        {
            var games = await _gameService.GetTopRatedGamesAsync(topCount);
            return Ok(games);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<GameEntity>>> SearchGames([FromQuery] string searchTerm)
        {
            var games = await _gameService.SearchGamesAsync(searchTerm);
            return Ok(games);
        }
    }
}