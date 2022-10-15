using JobsStats.API.DB;
using FakeItEasy;
using Microsoft.EntityFrameworkCore;
using JobsStats.API.DB.Models;
using Xunit;
using JobsStats.API.Types;

namespace JobsStats.API.Tests
{
    public class SqlJobStatisticsRepositoryTests
    {
        private SqlJobStatisticsRepository _repository;
        private JobStatsDbContext _context;

        private JobStatsDbContext GetOnMemoryDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<JobStatsDbContext>()
                .UseInMemoryDatabase(databaseName: "JobStatsDB")
                .Options;
            var databaseContext = new JobStatsDbContext(options);
            databaseContext.Database.EnsureCreated();
            return databaseContext;
        }
        public SqlJobStatisticsRepositoryTests()
        {
            _context = GetOnMemoryDatabaseContext();
            _repository = new SqlJobStatisticsRepository(_context);
        }

        public async Task SeedDataTestTimeRange()
        {
            _context.JobWatchesPerDays.Add(new JobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 1),
                JobId = 1,
                NumberOfWatches = 10
            });
            _context.JobWatchesPerDays.Add(new JobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 3),
                JobId = 1,
                NumberOfWatches = 10
            });
            _context.JobWatchesPerDays.Add(new JobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 4),
                JobId = 1,
                NumberOfWatches = 10
            });
            _context.JobWatchesPerDays.Add(new JobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 7),
                JobId = 1,
                NumberOfWatches = 10
            });
            await _context.SaveChangesAsync();
        }

        [Fact]
        public async Task GetStatisticsPerDayInRange_WhenInputRangeInMiddleOfEntireDataRange_ReturnstatisticsInRange()
        {
            await SeedDataTestTimeRange();
            await _context.SaveChangesAsync();


            var queryResult = await _repository.GetStatisticsPerDayInRange(new DateTime(1990, 1, 3), new DateTime(1990, 1, 4));
            Assert.NotNull(queryResult);
            Assert.Equal(2, queryResult.Count());
            Assert.True(AreDateDaysEqual(queryResult[0].date,new DateDay { Year = 1990 , Month = 1 , Day = 3 }));
            Assert.True(AreDateDaysEqual(queryResult[1].date, new DateDay { Year = 1990, Month = 1, Day = 4 }));
        }

        [Fact]
        public async Task GetStatisticsPerDayInRange_WhenInputRangeInLeftSideOfEntireDataRange_ReturnstatisticsInRange()
        {
            await SeedDataTestTimeRange();
            await _context.SaveChangesAsync();


            var queryResult = await _repository.GetStatisticsPerDayInRange(new DateTime(1989, 1, 3), new DateTime(1990, 1, 3));
            Assert.NotNull(queryResult);
            Assert.Equal(2, queryResult.Count());
            Assert.True(AreDateDaysEqual(queryResult[0].date, new DateDay { Year = 1990, Month = 1, Day = 1 }));
            Assert.True(AreDateDaysEqual(queryResult[1].date, new DateDay { Year = 1990, Month = 1, Day = 3 }));
        }

        [Fact]
        public async Task GetStatisticsPerDayInRange_WhenInputRangeOutsideOfEntireDataRange_ReturnstatisticsInRange()
        {
            await SeedDataTestTimeRange();
            await _context.SaveChangesAsync();


            var queryResult = await _repository.GetStatisticsPerDayInRange(new DateTime(2000, 1, 3), new DateTime(2022, 1, 3));
            Assert.NotNull(queryResult);
            Assert.Equal(0, queryResult.Count());
        }


        public async Task SeedDataMultipleJobsPerDay()
        {
            _context.JobWatchesPerDays.Add(new JobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 1),
                JobId = 1,
                NumberOfWatches = 10
            });
            _context.JobWatchesPerDays.Add(new JobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 3),
                JobId = 1,
                NumberOfWatches = 10
            });
            _context.JobWatchesPerDays.Add(new JobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 3),
                JobId = 2,
                NumberOfWatches = 10
            });
            _context.JobWatchesPerDays.Add(new JobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 7),
                JobId = 1,
                NumberOfWatches = 10
            });
            await _context.SaveChangesAsync();
        }

        [Fact]
        public async Task GetStatisticsPerDayInRange_WhenInputRangeCoversMultipleJobs_ReturnsSumsOfJobs()
        {
            await SeedDataMultipleJobsPerDay();
            await _context.SaveChangesAsync();

            var queryResult = await _repository.GetStatisticsPerDayInRange(new DateTime(1990, 1, 3), new DateTime(1990, 1, 3));
            Assert.NotNull(queryResult);
            Assert.Equal(1, queryResult.Count());
            Assert.Equal(20, queryResult[0].NumberOfWatches);
            Assert.Equal(2, queryResult[0].NumberOfDistinctJobs);
        }

        [Fact]
        public async Task GetStatisticsPerDayInRange_WhenInputRangeCoversSingle_ReturnsDataOfOnlyJob()
        {
            await SeedDataMultipleJobsPerDay();
            await _context.SaveChangesAsync();

            var queryResult = await _repository.GetStatisticsPerDayInRange(new DateTime(1990, 1, 7), new DateTime(1990, 1, 9));
            Assert.NotNull(queryResult);
            Assert.Equal(1, queryResult.Count());
            Assert.Equal(10, queryResult[0].NumberOfWatches);
            Assert.Equal(1, queryResult[0].NumberOfDistinctJobs);
        }


        public async Task SeedPredictedDataTestTimeRange()
        {
            _context.PredictedJobWatchesPerDays.Add(new PredictedJobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 1),
                PredictedNumberOfWatches = 10
            });
            _context.PredictedJobWatchesPerDays.Add(new PredictedJobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 3),
                PredictedNumberOfWatches = 10
            });
            _context.PredictedJobWatchesPerDays.Add(new PredictedJobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 4),
                PredictedNumberOfWatches = 10
            });
            _context.PredictedJobWatchesPerDays.Add(new PredictedJobWatchesPerDay
            {
                Date = new DateTime(1990, 1, 7),
                PredictedNumberOfWatches = 20
            });
            await _context.SaveChangesAsync();
        }

        [Fact]
        public async Task GetPredictedStatisticsPerDayInRange_WhenInputRangeInMiddleOfEntireDataRange_ReturnstatisticsInRange()
        {
            await SeedPredictedDataTestTimeRange();
            await _context.SaveChangesAsync();


            var queryResult = await _repository.GetPredictionsPerDayInRange(new DateTime(1990, 1, 3), new DateTime(1990, 1, 4));
            Assert.NotNull(queryResult);
            Assert.Equal(2, queryResult.Count());
            Assert.True(AreDateDaysEqual(queryResult[0].Date, new DateDay { Year = 1990, Month = 1, Day = 3 }));
            Assert.True(AreDateDaysEqual(queryResult[1].Date, new DateDay { Year = 1990, Month = 1, Day = 4 }));
        }

        [Fact]
        public async Task GetPredictedStatisticsPerDayInRange_WhenInputRangeInLeftSideOfEntireDataRange_ReturnstatisticsInRange()
        {
            await SeedPredictedDataTestTimeRange();
            await _context.SaveChangesAsync();


            var queryResult = await _repository.GetPredictionsPerDayInRange(new DateTime(1990, 1, 4), new DateTime(1990, 1, 7));
            Assert.NotNull(queryResult);
            Assert.Equal(2, queryResult.Count());
            Assert.True(AreDateDaysEqual(queryResult[0].Date, new DateDay { Year = 1990, Month = 1, Day = 4 }));
            Assert.True(AreDateDaysEqual(queryResult[1].Date, new DateDay { Year = 1990, Month = 1, Day = 7 }));
            Assert.Equal(queryResult[0].PredictedNumberOfWatches, 10);
            Assert.Equal(queryResult[1].PredictedNumberOfWatches, 20);
        }

        [Fact]
        public async Task GetPredictedStatisticsPerDayInRange_WhenInputRangeOutsideOfEntireDataRange_ReturnstatisticsInRange()
        {
            await SeedPredictedDataTestTimeRange();
            await _context.SaveChangesAsync();


            var queryResult = await _repository.GetPredictionsPerDayInRange(new DateTime(2000, 1, 3), new DateTime(2022, 1, 3));
            Assert.NotNull(queryResult);
            Assert.Equal(0, queryResult.Count());
        }

        bool AreDateDaysEqual(DateDay dateDayLeft , DateDay dateDayRight)
        {
            if (dateDayLeft==null && dateDayRight==null) return true;
            if (dateDayLeft != null && dateDayRight == null) return false;
            if (dateDayLeft == null && dateDayRight != null) return false;
            return dateDayLeft.Day == dateDayRight.Day &&
                dateDayLeft.Month == dateDayRight.Month && 
                dateDayLeft.Year == dateDayRight.Year;
        }

    }
}
