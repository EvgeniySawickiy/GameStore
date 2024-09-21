using GameStore.DataAccess.Postgres.Models;

namespace GameStore.Core.Interfaces.Services
{
    public interface IUserService : IService<UserEntity>
    {
        Task<UserEntity> GetUserByEmailAsync(string email);
        Task<IEnumerable<UserEntity>> GetUsersByRoleAsync(string role);
    }
}
