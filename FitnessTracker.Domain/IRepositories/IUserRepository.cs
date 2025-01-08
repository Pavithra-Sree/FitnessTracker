using FitnessTracker.Domain.Entities;

namespace FitnessTracker.Domain.IRepositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(Guid id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(Guid id);
    }
}
