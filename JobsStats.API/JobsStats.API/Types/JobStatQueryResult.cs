namespace JobsStats.API.Types
{
    public class JobStat
    {
        public DateDay date { get; set; }
        public int NumberOfWatches { get; set; }
        public int NumberOfDistinctJobs { get; set; }
    }
}
