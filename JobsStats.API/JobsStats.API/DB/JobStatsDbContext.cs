using JobsStats.API.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace JobsStats.API.DB
{
    public class JobStatsDbContext : DbContext
    {

        private int numberOfCompanies = 10;
        private int watchesUpperLimit = 70;
        
        public JobStatsDbContext(DbContextOptions<JobStatsDbContext> options): base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.EnableSensitiveDataLogging()
                .UseSqlServer(@"Server=(LocalDB)\JobStatsDatabase;Database=JobStatsDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobWatchesPerDay>().HasData(
                GenerateDataJobWachesPerDay()
                );
            modelBuilder.Entity<PredictedJobWatchesPerDay>().HasData(
                GenerateDataPredictedJobWachesPerDay()
                );
        }

        #region Private Methods

        private List<JobWatchesPerDay> GenerateDataJobWachesPerDay()
        {
            Random random = new Random();
            var statistics = new List<JobWatchesPerDay>();
            int id = 1;
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < random.Next(0, numberOfCompanies); j++)
                {
                    statistics.Add(new JobWatchesPerDay
                    { Id = id++, Date = DateTime.Now.AddDays(i), JobId = j, NumberOfWatches = random.Next(1, watchesUpperLimit) });
                }
            }
            return statistics;
        }

        private List<PredictedJobWatchesPerDay> GenerateDataPredictedJobWachesPerDay()
        {
            Random random = new Random();
            var statistics = new List<PredictedJobWatchesPerDay>();
            for (int i = 0; i < 45; i++)
            {
                statistics.Add(new PredictedJobWatchesPerDay
                { Id = i+1, Date = DateTime.Now.AddDays(i), PredictedNumberOfWatches = random.Next(1, watchesUpperLimit) });
            }
            return statistics;
        }
        #endregion


        public virtual DbSet<JobWatchesPerDay>? JobWatchesPerDays { get; set; }
        public virtual DbSet<PredictedJobWatchesPerDay>? PredictedJobWatchesPerDays { get; set; }
    }
}
