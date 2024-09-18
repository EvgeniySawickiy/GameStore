using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DataAccess.Postgres.Models
{
    public class CategoryEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // Связи
        public List<GameEntity> GamesInCategory { get; set; }
    }

}
