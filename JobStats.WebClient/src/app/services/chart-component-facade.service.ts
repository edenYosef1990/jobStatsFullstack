import { Injectable, OnDestroy } from '@angular/core';
import { SubSink } from 'subsink';
import { JobStatsStore } from '../state/job-stats.component-store';
import { generateDataRange } from '../utils/dates.utils';
import { BehaviorSubject, combineLatestWith, Observable } from 'rxjs';
import { JobStatsToChartData } from '../utils/converters.utils';
import { DateDay, DateToDayDate } from '../types/dateDay';
import { TableData } from '../types/table-data';

@Injectable({
  providedIn: 'root',
})
export class ChartComponentFacadeService implements OnDestroy {
  subsink: SubSink = new SubSink();
  dateRangeLimits: { firstDay: DateDay; lastDay: DateDay };

  private _chartData$: BehaviorSubject<TableData> =
    new BehaviorSubject<TableData>([]);
  chartData$: Observable<TableData> = this._chartData$;

  ngOnDestroy() {
    this.subsink.unsubscribe();
  }

  constructor(private jobStatsStore: JobStatsStore) {
    this.dateRangeLimits = {
      firstDay: DateToDayDate(this.jobStatsStore.defaultRangeFirstDay),
      lastDay: DateToDayDate(this.jobStatsStore.defaultRangeLastDay),
    };

    this.subsink.sink = jobStatsStore.viewsPerDay$
      .pipe(combineLatestWith(jobStatsStore.PredictedJobsPerDay$))
      .subscribe(([jobViews, predictedJobViews]) => {
        let dateRange = generateDataRange(
          this.dateRangeLimits.firstDay,
          this.dateRangeLimits.lastDay
        );
        let chartData = JobStatsToChartData(
          dateRange,
          jobViews,
          predictedJobViews
        );
        this._chartData$.next(chartData);
      });
  }
}
