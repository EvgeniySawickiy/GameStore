using GameStore.DataAccess.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Core.Interfaces.Services
{
    public interface ICategoryService : IService<CategoryEntity>
    {
        Task<IEnumerable<CategoryEntity>> GetCategoriesByName(string name);
    }
}