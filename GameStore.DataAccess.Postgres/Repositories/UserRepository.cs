using GameStore.Core.Interfaces.Repositories;
using GameStore.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;


namespace GameStore.DataAccess.Postgres.Repositories
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        public UserRepository(GameStoreDbContext context) : base(context)
        {
        }

        public async Task<UserEntity> GetUserByEmailAsync(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<IEnumerable<UserEntity>> GetUsersByRoleAsync(string role)
        {
            return await _context.Users
                .Where(u => u.Role == role)
                .ToListAsync();
        }
    }
}
