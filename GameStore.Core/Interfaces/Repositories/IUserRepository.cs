using GameStore.DataAccess.Postgres.Models;


namespace GameStore.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        public interface IUserRepository : IRepository<UserEntity>
        {
            Task<UserEntity> GetUserByEmailAsync(string email);
            Task<IEnumerable<UserEntity>> GetUsersByRoleAsync(string role);
        }
    }
}

