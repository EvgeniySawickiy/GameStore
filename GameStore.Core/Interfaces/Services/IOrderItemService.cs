using GameStore.DataAccess.Postgres.Models;

namespace GameStore.Core.Interfaces.Services
{
    public interface IOrderItemService : IService<OrderItemEntity>
    {
        Task<IEnumerable<OrderItemEntity>> GetOrderItemsByOrderIdAsync(Guid orderId);
    }
}