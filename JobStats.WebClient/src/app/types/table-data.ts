import { DateDay } from './dateDay';

export type TableData = {

  date: DateDay;
  predictedJobViews: number | null;
  distinctJobs: number | null;
  jobViews: number | null;
}[];
