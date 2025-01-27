using FitnessTracker.Domain.Enums;
using FitnessTracker.Domain.ValueObjects;

namespace FitnessTracker.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }       
    }
}
