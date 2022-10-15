import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import {GoogleChartsModule} from 'angular-google-charts';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import {JobStatsService} from './services/job-stats-fetch.service';
import {ChartComponent} from './chart.component/chart.component';
import {ChartComponentFacadeService} from './services/chart-component-facade.service';

@NgModule({
  declarations: [
    AppComponent,
    ChartComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    GoogleChartsModule
  ],
  providers: [JobStatsService,ChartComponentFacadeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
