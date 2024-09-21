using GameStore.Core.Interfaces.Services;
using GameStore.DataAccess.Postgres.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewEntity>>> GetAllReviews()
        {
            var reviews = await _reviewService.GetAllAsync();
            return Ok(reviews);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReviewEntity>> GetReviewById(Guid id)
        {
            var review = await _reviewService.GetByIdAsync(id);
            if (review == null)
                return NotFound();

            return Ok(review);
        }

        [HttpPost]
        public async Task<IActionResult> AddReview([FromBody] ReviewEntity review)
        {
            await _reviewService.AddAsync(review);
            return CreatedAtAction(nameof(GetReviewById), new { id = review.Id }, review);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReview(Guid id, [FromBody] ReviewEntity review)
        {
            if (id != review.Id)
                return BadRequest();

            await _reviewService.UpdateAsync(review);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(Guid id)
        {
            await _reviewService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("game/{gameId}")]
        public async Task<ActionResult<IEnumerable<ReviewEntity>>> GetReviewsByGameId(Guid gameId)
        {
            var reviews = await _reviewService.GetReviewsByGameIdAsync(gameId);
            return Ok(reviews);
        }
    }
}