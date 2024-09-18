using GameStore.Core.Interfaces.Repositories;
using GameStore.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;


namespace GameStore.DataAccess.Postgres.Repositories
{
    public class OrderItemRepository : Repository<OrderItemEntity>, IOrderItemRepository
    {
        public OrderItemRepository(GameStoreDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<OrderItemEntity>> GetOrderItemsByOrderIdAsync(Guid orderId)
        {
            return await _context.OrderItems
                                 .Where(oi => oi.OrderId == orderId)
                                 .ToListAsync();
        }
    }
}