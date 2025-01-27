using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.IRepositories;
using FitnessTracker.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Infrastructure.Repositories
{
    public class GoalRepository : IGoalRepository
    {
        private readonly FitnessTrackerContext _context;
        public GoalRepository(FitnessTrackerContext context)
        {
            _context = context;
        }
        public async Task<Goal> DeleteGoal(Guid id)
        {
            var goal = await _context.Goals.FirstOrDefaultAsync(x => x.Id == id);
            if (goal == null)
            {
                return null;
            }

            _context.Goals.Remove(goal);
            await _context.SaveChangesAsync();

            return goal;
        }

        public async Task<IEnumerable<Goal>> GetAllGoals()
        {
            return await _context.Goals.ToListAsync();
        }

        public async Task<Goal> GetGoalById(Guid id)
        {
            var goal = await _context.Goals.FirstOrDefaultAsync(x => x.Id == id);
            if (goal == null)
            {
                return null;
            }
            return goal;
        }

        public async Task<Goal> InsertGoal(Goal goal)
        {
            await _context.Goals.AddAsync(goal);
            await _context.SaveChangesAsync();
            return goal;
        }

        public async Task<Goal> UpdateGoal(Guid id, Goal goal)
        {
            var existingGoal = await _context.Goals.FirstOrDefaultAsync(x => x.Id == id);
            if (existingGoal == null)
            {
                return null;
            }
            
            return existingGoal;
        }
    }
}
