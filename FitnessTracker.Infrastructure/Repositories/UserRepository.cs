using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.IRepositories;
using FitnessTracker.Infrastructure.Data.Context;

namespace FitnessTracker.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private FitnessTrackerContext _context;
        public UserRepository(FitnessTrackerContext context)
        {
            this._context = context;
        }

        void IUserRepository.DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<User> IUserRepository.GetAllUsers()
        {
            throw new NotImplementedException();
        }

        User IUserRepository.GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
