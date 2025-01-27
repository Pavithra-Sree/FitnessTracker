using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Infrastructure.Data.Context
{
    public class FitnessTrackerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public FitnessTrackerContext(DbContextOptions<FitnessTrackerContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure User Entity
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.UserId);

                entity.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(30);

                entity.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(30);                
            });

            // Configure Goal Entity
            modelBuilder.Entity<Goal>(entity =>
            {
                entity.HasKey(g => g.Id);


                entity.Property(g => g.GoalType)
                .HasConversion<string>()
                .IsRequired();

                entity.OwnsOne(g => g.TargetValue, targetValue =>
                {
                    targetValue.Property(t => t.Weight)
                    .HasColumnType("decimal(5,2)")
                    .IsRequired();

                    targetValue.Property(t => t.TargetDate)
                    .HasColumnType("date")
                    .IsRequired();

                    targetValue.ToTable("Goals");
                });

                entity.Property(g => g.StartDate)
                .HasColumnType("date")
                .IsRequired();

                entity.Property(g => g.EndDate)
                .HasColumnType("date")
                .IsRequired();

                entity.Property(g => g.Status)
                .HasConversion<string>();
            });

            // Configure Workout Entity
            modelBuilder.Entity<Workout>(entity =>
            {
                entity.HasKey(w => w.Id);

                entity.HasOne<User>()
                .WithMany()
                .HasForeignKey(w => w.UserId)
                .IsRequired();

                entity.Property(w => w.Type)
                .HasConversion<string>()
                .IsRequired();

                entity.Property(w => w.Duration)
                .HasColumnType("time")
                .IsRequired(false);

                entity.Property(w => w.CaloriesBurned)
                .HasColumnType("decimal(10, 2)")
                .IsRequired(false);
            });

            // Configure ActivityLog Entity
            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.HasKey(a => a.ActivityLogId);

                entity.HasOne<User>()
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

                entity.Property(a => a.Date)
                .HasColumnType("date")
                .IsRequired();

                //entity.HasMany(a => a.Workouts)
                //.WithOne()
                //.HasForeignKey(a => a.UserId)
                //.OnDelete(DeleteBehavior.Cascade);

                entity.Property(a => a.Steps)
                .IsRequired(false);

                entity.Property(al => al.HeartRate)
                .HasColumnType("decimal(5, 2)")
                .IsRequired(false);
            });
        }
    }
}
