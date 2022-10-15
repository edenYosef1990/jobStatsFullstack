namespace JobsStats.API.Types
{
    public class DateDay
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public static DateDay DateTimeToDateDay(DateTime dateTime) =>
    new DateDay { Day = dateTime.Day, Month = dateTime.Month, Year = dateTime.Year };
    }
}
