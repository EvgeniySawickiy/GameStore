using GameStore.Core.Interfaces.Repositories;
using GameStore.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DataAccess.Postgres.Repositories
{
    public class CategoryRepository : Repository<CategoryEntity>, ICategoryRepository
    {
        public CategoryRepository(GameStoreDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<CategoryEntity>> GetCategoriesByName(string name)
        {
            return await _context.Categories.Where(c => c.Name.Contains(name)).ToListAsync();
        }
    }
}