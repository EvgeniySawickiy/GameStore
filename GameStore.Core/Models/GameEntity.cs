
namespace GameStore.DataAccess.Postgres.Models
{
    public class GameEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverImageUrl { get; set; }

        // Связи
        public List<CategoryEntity> GameCategories { get; set; }
        public List<ReviewEntity> Reviews { get; set; }
        public List<OrderItemEntity> OrderItems { get; set; }
    }
}
