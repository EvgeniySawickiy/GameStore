using GameStore.Core.Interfaces.Repositories;
using GameStore.Core.Interfaces.Services;
using GameStore.DataAccess.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Services
{
    public class ReviewService : Service<ReviewEntity>, IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository) : base(reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<IEnumerable<ReviewEntity>> GetReviewsByGameIdAsync(Guid gameId)
        {
            return await _reviewRepository.GetReviewsByGameIdAsync(gameId);
        }

        public async Task<IEnumerable<ReviewEntity>> GetReviewsByUserIdAsync(Guid userId)
        {
            return await _reviewRepository.GetReviewsByUserIdAsync(userId);
        }
    }
}