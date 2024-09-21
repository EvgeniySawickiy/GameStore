using GameStore.DataAccess.Postgres.Models;

namespace GameStore.Core.Interfaces.Services
{
    public interface IPaymentService : IService<PaymentEntity>
    {
        Task<IEnumerable<PaymentEntity>> GetPaymentsByOrderIdAsync(Guid orderId);
    }
}