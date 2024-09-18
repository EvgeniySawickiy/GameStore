
namespace GameStore.DataAccess.Postgres.Models
{
    public class PaymentEntity
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }
        public OrderEntity Order { get; set; }

        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; } // e.g., CreditCard, PayPal
        public string Status { get; set; } // e.g., Completed, Pending, Failed
    }

}
