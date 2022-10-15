using JobsStats.API.DB.Models;
using JobsStats.API.Types;

namespace JobsStats.API.DB
{
    public interface IJobStatisticsRepository : IDisposable
    {
        Task<List<JobStat>> GetStatisticsPerDayInRange(DateTime firstDay, DateTime lastDay);
        Task<List<PredictedJobStat>> GetPredictionsPerDayInRange(DateTime firstDay, DateTime lastDay);
    }
}
