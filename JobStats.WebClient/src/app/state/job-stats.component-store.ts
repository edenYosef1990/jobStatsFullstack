import { Injectable, OnInit } from '@angular/core';
import { ComponentStore } from '@ngrx/component-store';
import { catchError, EMPTY, Observable, switchMap, tap, forkJoin } from 'rxjs';
import { JobStatsService } from '../services/job-stats-fetch.service';
import { JobStat } from '../types/job-stat';
import { PredictedJobStat } from '../types/predicted-job-stat';

export interface JobStatsState {
  dayStats: JobStat[];
  predicteedDayStats: PredictedJobStat[];
  rangeFirstDay: Date | null;
  rangeLastDay: Date | null;
}

@Injectable({
  providedIn: 'root',
})
export class JobStatsStore extends ComponentStore<JobStatsState> {
  constructor(private jobStatsService: JobStatsService) {
    super({
      dayStats: [],
      predicteedDayStats: [],
      rangeFirstDay: null,
      rangeLastDay: null,
    });
    this.init();
  }

  //Actions
  readonly defaultRangeFirstDay: Date = new Date(2022, 10, 4);
  readonly defaultRangeLastDay: Date = new Date(2022, 10, 30);

  readonly LoadChartData = this.updater(
    (
      state,
      change: {
        jobStatsPerDay: JobStat[];
        range: { rangeFirstDay: Date; rangeLastDay: Date };
      }
    ) => ({
      ...state,
      dayStats: change.jobStatsPerDay,
      rangeFirstDay: change.range.rangeFirstDay,
      rangeLastDay: change.range.rangeLastDay,
    })
  );

  readonly LoadPredictedChartData = this.updater(
    (state, predicteedDayStats: PredictedJobStat[]) => ({
      ...state,
      predicteedDayStats: predicteedDayStats,
    })
  );

  //Effects

  readonly loadDataInDatesRange = this.effect(
    (range$: Observable<{ rangeFirstDay: Date; rangeLastDay: Date }>) => {
      return range$.pipe(
        switchMap((dateRange) =>
          this.jobStatsService
            .getJobStats(dateRange.rangeFirstDay, dateRange.rangeLastDay)
            .pipe(
              tap({
                next: (result) =>
                  this.LoadChartData({
                    jobStatsPerDay: result,
                    range: dateRange,
                  }),
              }),
              catchError(() => EMPTY)
            )
        )
      );
    }
  );

  //OnInit implementation

  init() {
    let response1 = this.jobStatsService.getPredictedJobStats(
      this.defaultRangeFirstDay,
      this.defaultRangeLastDay
    );
    let response2 = this.jobStatsService.getJobStats(
      this.defaultRangeFirstDay,
      this.defaultRangeLastDay
    );
    forkJoin([response1, response2]).subscribe(([res1, jobStatsPerDay]) => {
      this.setState({
        dayStats: jobStatsPerDay,
        predicteedDayStats: res1,
        rangeFirstDay: null,
        rangeLastDay: null,
      });
    });
  }

  //Selectors

  readonly viewsPerDay$: Observable<JobStat[]> = this.select(
    (state) => state.dayStats
  );
  readonly PredictedJobsPerDay$: Observable<PredictedJobStat[]> = this.select(
    (state) => state.predicteedDayStats
  );
}
