namespace JobsStats.API.Types
{
    public class QueryResult
    {
        public IEnumerable<JobStat> DayStats { get; set; }
    }
}
