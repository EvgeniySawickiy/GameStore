using GameStore.Core.Interfaces.Repositories;
using GameStore.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.DataAccess.Postgres.Repositories
{
    public class PaymentRepository : Repository<PaymentEntity>, IPaymentRepository
    {
        public PaymentRepository(GameStoreDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PaymentEntity>> GetPaymentsByOrderIdAsync(Guid orderId)
        {
            return await _context.Payments
                                 .Where(p => p.OrderId == orderId)
                                 .ToListAsync();
        }

    }
}
