using JobsStats.API.DB.Models;
using JobsStats.API.Types;
using Microsoft.EntityFrameworkCore;

namespace JobsStats.API.DB
{
    public class SqlJobStatisticsRepository : IJobStatisticsRepository
    {
        private JobStatsDbContext _context;
        public SqlJobStatisticsRepository(JobStatsDbContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<List<JobStat>> GetStatisticsPerDayInRange(DateTime firstDay, DateTime lastDay)
        {
            var filteredList = _context.JobWatchesPerDays
                .AsNoTracking()
                .Where(
                jobStat =>
                jobStat.Date >= firstDay && jobStat.Date <= lastDay);

            var statsPerDay = await filteredList.GroupBy(JobsStats => JobsStats.Date.Day)
                .Select(statsPerDay => new JobStat()
                {
                    date = DateDay.DateTimeToDateDay(statsPerDay.First().Date),
                    NumberOfWatches = statsPerDay.Sum(stat => stat.NumberOfWatches),
                    NumberOfDistinctJobs = statsPerDay.Select(stat => stat.JobId).Distinct().Count()
                }).ToListAsync();

            return statsPerDay;
        }

        public async Task<List<PredictedJobStat>> GetPredictionsPerDayInRange(DateTime firstDay, DateTime lastDay)
        {
            return await _context.PredictedJobWatchesPerDays
                .AsNoTracking()
                .Where(
                jobStat =>
                jobStat.Date >= firstDay && jobStat.Date <= lastDay)
                .Select(predictedJobState => new PredictedJobStat { 
                    Date = DateDay.DateTimeToDateDay(predictedJobState.Date) , 
                    PredictedNumberOfWatches = predictedJobState.PredictedNumberOfWatches })
                .ToListAsync();
        }
    }
}
