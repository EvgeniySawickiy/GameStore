using GameStore.DataAccess.Postgres.Models;


namespace GameStore.Core.Interfaces.Repositories
{
    namespace GameStore.Core.Repositories
    {
        public interface IOrderRepository : IRepository<OrderEntity>
        {
            Task<IEnumerable<OrderEntity>> GetOrdersByUserIdAsync(Guid userId);
            Task<IEnumerable<OrderEntity>> GetOrdersByDateAsync(DateTime date);
            Task<decimal> GetTotalRevenueAsync();
        }
    }
}