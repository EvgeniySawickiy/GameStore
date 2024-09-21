using GameStore.DataAccess.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Core.Interfaces.Services
{
    public interface IOrderService : IService<OrderEntity>
    {
        Task<IEnumerable<OrderEntity>> GetOrdersByUserIdAsync(Guid userId);
        Task<IEnumerable<OrderEntity>> GetOrdersByDateAsync(DateTime date);
        Task<decimal> GetTotalRevenueAsync();
    }
}