using FitnessTracker.Domain.Enums;
using FitnessTracker.Domain.ValueObjects;

namespace FitnessTracker.Domain.Entities
{
    public class Goal
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; } // Foreign key
        public User? UserDetail { get; set; } // Navigation Property
        public GoalType GoalType { get; set; }
        public TargetValue? TargetValue { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public Status? Status { get; set; }
    }
}
