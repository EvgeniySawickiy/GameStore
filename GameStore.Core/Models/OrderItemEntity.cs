
namespace GameStore.DataAccess.Postgres.Models
{
    public class OrderItemEntity
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }
        public OrderEntity Order { get; set; }

        public Guid GameId { get; set; }
        public GameEntity Game { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

}
