using FitnessTracker.Domain.Enums;
using FitnessTracker.Domain.ValueObjects;

namespace FitnessTracker.Domain.Entities
{
    public class PersonalDetails
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User UserDetail { get; set; } // Navigation Property
        public DateOnly DateOfBirth { get; set; }
        public Gender? Gender { get; set; } // Enum       
        public BodyMetrics BodyMetrics { get; set; } // Value Object
        public ActivityLevel? ActivityLevel { get; set; } // Enum
        public List<Goal> Goals { get; set; }
    }
}
