import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map, tap } from 'rxjs';
import {JobStat} from '../types/job-stat';
import { PredictedJobStat } from '../types/predicted-job-stat';

@Injectable({
  providedIn: 'root',
})
export class JobStatsService {
  url = 'http://localhost:5215/JobStaticstics';
  constructor(private http: HttpClient) {}

  formatDateToString(date: Date) {
    return (
      `${date.getMonth().toString().padStart(2, '0')}` +
      `-${date.getDate().toString().padStart(2, '0')}` +
      `-${date.getFullYear().toString().padStart(4, '0')}`
    );
  }
  getJobStats(firstDay: Date, lastDay: Date): Observable<JobStat[]> {
    let params = new HttpParams()
      .set('firstDay', this.formatDateToString(firstDay))
      .set('lastDay', this.formatDateToString(lastDay));
    return this.http
      .get<JobStat[]>(this.url + '/GetJobsWatchStaticisPerDay', {
        params: params,
      });
  }

  getPredictedJobStats(
    firstDay: Date,
    lastDay: Date
  ): Observable<PredictedJobStat[]> {
    let params = new HttpParams()
      .set('firstDay', this.formatDateToString(firstDay))
      .set('lastDay', this.formatDateToString(lastDay));
    return this.http
      .get<PredictedJobStat[]>(this.url + '/GetPredictedStatistics', {
        params: params,
      })
  }
}
