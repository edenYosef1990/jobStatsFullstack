import { Component } from '@angular/core';
import { JobStatsService } from './services/job-stats-fetch.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'JobStats.WebClient';
  constructor() {}
}
