using FitnessTracker.Domain.Entities;

namespace FitnessTracker.Domain.IRepositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(Guid id);
        Task<User> InsertUser(User user);
        Task<User> UpdateUser(Guid id, User user);
        Task<User> DeleteUser(Guid id);
    }
}
