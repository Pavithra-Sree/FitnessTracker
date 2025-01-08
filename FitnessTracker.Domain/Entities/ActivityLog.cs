namespace FitnessTracker.Domain.Entities
{
    public class ActivityLog
    {
        public Guid ActivityLogId { get; set; }
        public Guid UserId { get; set; }
        public DateOnly Date {  get; set; }
        // public List<Workout>? Workouts { get; set; }
        public int? Steps { get; set; }
        public double? HeartRate { get; set; }
    }
}
