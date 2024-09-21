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
    public class OrderItemService : Service<OrderItemEntity>, IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemService(IOrderItemRepository orderItemRepository) : base(orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public async Task<IEnumerable<OrderItemEntity>> GetOrderItemsByOrderIdAsync(Guid orderId)
        {
            return await _orderItemRepository.GetOrderItemsByOrderIdAsync(orderId);
        }
    }
}