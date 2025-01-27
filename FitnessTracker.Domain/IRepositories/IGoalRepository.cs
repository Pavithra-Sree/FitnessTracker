using FitnessTracker.Domain.Entities;

namespace FitnessTracker.Domain.IRepositories
{
    public interface IGoalRepository
    {
        Task<IEnumerable<Goal>> GetAllGoals();
        Task<Goal> GetGoalById(Guid id);
        Task<Goal> InsertGoal(Goal goal);
        Task<Goal> UpdateGoal(Guid id, Goal goal);
        Task<Goal> DeleteGoal(Guid id);
    }
}
