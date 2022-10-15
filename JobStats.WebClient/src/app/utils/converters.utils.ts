import { DateDay } from '../types/dateDay';
import { JobStat } from '../types/job-stat';
import { PredictedJobStat } from '../types/predicted-job-stat';
import { TableData } from '../types/table-data';
import { dateDayToString } from '../utils/dates.utils';

export function JobStatsToChartData(
  datesRange: DateDay[],
  jobStats: JobStat[],
  predictedJobStats: PredictedJobStat[]
): TableData {
  let datesDict: {
    [dayTimestampKey: string]: {
      predictedJobViews: number | null;
      jobViews: number | null;
      distinctJobs: number | null;
      date: DateDay;
    };
  } = {};
  for (let i = 0; i < datesRange.length; i++) {
    datesDict[dateDayToString(datesRange[i])] = {
      predictedJobViews: null,
      jobViews: null,
      distinctJobs: null,
      date: datesRange[i],
    };
  }
  for (let jobStat of jobStats) {
    datesDict[dateDayToString(jobStat.date)].jobViews = jobStat.numberOfWatches;
    datesDict[dateDayToString(jobStat.date)].distinctJobs =
      jobStat.numberOfDistinctJobs;
  }
  for (let predictedJobStat of predictedJobStats) {
    datesDict[dateDayToString(predictedJobStat.date)].predictedJobViews =
      predictedJobStat.predictedNumberOfWatches;
  }

  let chartData: TableData = [];
  for (let key in datesDict) {
    let dayData = datesDict[key];
    chartData.push({
      date: dayData.date,
      predictedJobViews: dayData.predictedJobViews,
      distinctJobs: dayData.distinctJobs,
      jobViews: dayData.jobViews,
    });
  }
  return chartData;
}

export function dateDayToDateView(dateDay: DateDay): string {
  const monthNames = [
    'January',
    'February',
    'March',
    'April',
    'May',
    'June',
    'July',
    'August',
    'September',
    'October',
    'November',
    'December',
  ];
  return `${monthNames[dateDay.month - 1]} ${dateDay.day}`;
}
