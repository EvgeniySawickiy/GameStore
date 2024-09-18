using GameStore.DataAccess.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Core.Interfaces.Repositories
{
    public interface IOrderItemRepository : IRepository<OrderItemEntity>
    {
        Task<IEnumerable<OrderItemEntity>> GetOrderItemsByOrderIdAsync(Guid orderId);
    }
}