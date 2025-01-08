using FitnessTracker.Domain.Enums;
using FitnessTracker.Domain.ValueObjects;

namespace FitnessTracker.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Gender? Gender { get; set; } // Enum       
        public BodyMetrics BodyMetrics { get; set; } // Value Object
        public ActivityLevel? ActivityLevel { get; set; } // Enum
        public List<Goal> Goals { get; set; }
    }
}
