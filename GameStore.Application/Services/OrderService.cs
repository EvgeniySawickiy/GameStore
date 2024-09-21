using GameStore.Core.Interfaces.Repositories.GameStore.Core.Repositories;
using GameStore.Core.Interfaces.Services;
using GameStore.DataAccess.Postgres.Models;

namespace GameStore.Application.Services
{
    public class OrderService : Service<OrderEntity>, IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository) : base(orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<OrderEntity>> GetOrdersByUserIdAsync(Guid userId)
        {
            return await _orderRepository.GetOrdersByUserIdAsync(userId);
        }

        public async Task<IEnumerable<OrderEntity>> GetOrdersByDateAsync(DateTime date)
        {
            return await _orderRepository.GetOrdersByDateAsync(date);
        }

        public async Task<decimal> GetTotalRevenueAsync()
        {
            return await _orderRepository.GetTotalRevenueAsync();
        }
    }
}