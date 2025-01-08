using FitnessTracker.Domain.Enums;

namespace FitnessTracker.Domain.Entities
{
    public class Workout
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; } // Foreign Key
        public WorkoutType Type { get; set; }
        public TimeOnly? Duration { get; set; }
        public double? CaloriesBurned { get; set; }
    }
}
