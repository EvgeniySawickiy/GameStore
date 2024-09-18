using GameStore.Core.Interfaces.Repositories.GameStore.Core.Repositories;
using GameStore.Core.Interfaces.Repositories;
using GameStore.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DataAccess.Postgres.Repositories
{
    public class OrderRepository : Repository<OrderEntity>, IOrderRepository
    {
        public OrderRepository(GameStoreDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<OrderEntity>> GetOrdersByUserIdAsync(Guid userId)
        {
            return await _context.Orders
            .Where(o => o.UserId == userId)
                                 .ToListAsync();
        }

        public async Task<IEnumerable<OrderEntity>> GetOrdersByDateAsync(DateTime date)
        {
            return await _context.Orders
                .Where(o => o.OrderDate == date)
                .ToListAsync();
        }

        public async Task<decimal> GetTotalRevenueAsync()
        {
            return await _context.Orders
                .SumAsync(o => o.TotalAmount);
        }
    }
}