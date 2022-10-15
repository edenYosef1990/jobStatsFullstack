using JobsStats.API.DB;
using JobsStats.API.Types;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace JobsStats.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class JobStaticsticsController : ControllerBase
    {
        private IJobStatisticsRepository _jobStatisticsRepository;

        public JobStaticsticsController(IJobStatisticsRepository jobStatisticsRepository)
        {
            _jobStatisticsRepository = jobStatisticsRepository;
        }

        private DateTime? dateStrToDate(string dateStr)
        {
            if (!DateTime.TryParseExact(dateStr, "MM-dd-yyyy", CultureInfo.InvariantCulture,
                                       DateTimeStyles.None, out DateTime dateValue))
            {
                return null;
            }
            return dateValue;
        }

        [HttpGet(Name = "GetJobsWatchStaticisPerDay")]
        public async Task<List<JobStat>> GetJobsWatchStaticisPerDay([FromQuery] string firstDay, [FromQuery] string lastDay)
        {
            var firstDayDate = dateStrToDate(firstDay);
            var lastDayDate = dateStrToDate(lastDay);
            if (firstDayDate == null || lastDayDate == null)
            {
                return null;
            }
            var res = await _jobStatisticsRepository.GetStatisticsPerDayInRange(firstDayDate.Value, lastDayDate.Value);
            return res;
        }

        [HttpGet(Name = "GetPredictedJobsWatchStaticisPerDay")]
        public async Task<List<PredictedJobStat>?> GetPredictedStatistics([FromQuery] string firstDay, [FromQuery] string lastDay)
        {
            var firstDayDate = dateStrToDate(firstDay);
            var lastDayDate = dateStrToDate(lastDay);
            if (firstDayDate == null || lastDayDate == null)
            {
                return null;
            }
            return await _jobStatisticsRepository.GetPredictionsPerDayInRange(firstDayDate.Value, lastDayDate.Value);
        }

    }
}
