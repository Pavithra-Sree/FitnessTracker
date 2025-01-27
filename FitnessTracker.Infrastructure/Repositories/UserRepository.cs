using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.IRepositories;
using FitnessTracker.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private FitnessTrackerContext _context;
        public UserRepository(FitnessTrackerContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetUserById(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public async Task<User> InsertUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;        
        }

        public async Task<User?> UpdateUser(Guid id, User user)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
            if (existingUser == null)
            {
                return null;
            }
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;

            await _context.SaveChangesAsync();

            return existingUser;
        }

        public async Task<User?> DeleteUser(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
            if (user == null)
            {
                return null;
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

    }
}
