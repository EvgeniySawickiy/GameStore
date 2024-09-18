using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DataAccess.Postgres.Models
{
    public class ReviewEntity
    {
        public Guid Id { get; set; }

        public Guid GameId { get; set; }
        public GameEntity Game { get; set; }

        public Guid UserId { get; set; }
        public UserEntity User { get; set; }

        public int Rating { get; set; } // Оценка от 1 до 5
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
    }

}
