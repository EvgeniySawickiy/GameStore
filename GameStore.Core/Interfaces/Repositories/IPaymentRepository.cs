using GameStore.DataAccess.Postgres.Models;

namespace GameStore.Core.Interfaces.Repositories
{
    public interface IPaymentRepository : IRepository<PaymentEntity>
    {
        Task<IEnumerable<PaymentEntity>> GetPaymentsByOrderIdAsync(Guid orderId);
    }
}