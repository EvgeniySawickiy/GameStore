

namespace GameStore.DataAccess.Postgres.Models
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // e.g., Admin, Customer
        public DateTime DateRegistered { get; set; }

        // Связи
        public List<OrderEntity> Orders { get; set; }
        public List<ReviewEntity> Reviews { get; set; }
    }

}
