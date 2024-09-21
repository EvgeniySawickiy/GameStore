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
    public class PaymentService : Service<PaymentEntity>, IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository) : base(paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<IEnumerable<PaymentEntity>> GetPaymentsByOrderIdAsync(Guid orderId)
        {
            return await _paymentRepository.GetPaymentsByOrderIdAsync(orderId);
        }
    }
}