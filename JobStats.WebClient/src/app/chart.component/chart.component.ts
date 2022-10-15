import { Component, OnDestroy } from '@angular/core';
import { ChartSelectionChangedEvent, ChartType } from 'angular-google-charts';
import { SubSink } from 'subsink';
import { ChartComponentFacadeService } from '../services/chart-component-facade.service';
import { TableDataView } from '../types/tabla-data-view';
import { TableData } from '../types/table-data';
import { dateDayToDateView } from '../utils/converters.utils';
import { JobStatsStore } from '../state/job-stats.component-store';

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
})
export class ChartComponent implements OnDestroy {
  constructor(
    chartComponentFacade: ChartComponentFacadeService,
    private jobStatsStore: JobStatsStore
  ) {
    this.subsink.sink = chartComponentFacade.chartData$.subscribe(
      (chartData) => {
        this.originalData = chartData;
        this.data = this.tableDataToViewSameItemsOrder(chartData);
      }
    );
  }

  tableDataToViewSameItemsOrder(tableData: TableData): TableDataView {
    let tableDataView = [];
    for (let i = 0; i < tableData.length; i++) {
      tableDataView.push([
        dateDayToDateView(tableData[i].date),
        tableData[i].jobViews,
        tableData[i].predictedJobViews,
        tableData[i].distinctJobs,
      ]);
    }
    return tableDataView;
  }

  ngOnDestroy(): void {
    this.subsink.unsubscribe();
  }

  onSelect(event: ChartSelectionChangedEvent) {
    let lastDayInRange = this.originalData[event.selection[0].row!].date;
    this.jobStatsStore.loadDataInDatesRange({
      rangeFirstDay: this.jobStatsStore.defaultRangeFirstDay,
      rangeLastDay: new Date(
        lastDayInRange.year,
        lastDayInRange.month,
        lastDayInRange.day
      ),
    });
  }

  originalData: TableData = [];

  subsink: SubSink = new SubSink();
  title = 'Fruits distribution';
  data: TableDataView = [];
  columnNames = ['Commulative Info', 'Commulative Job Views', 'Commulative Predicted Job Views', 'Active Jobs'];
  options = {
    crosshair: { trigger: 'both', orientation: 'vertical' },
    vAxis: {
      title: 'Commulative Info',
    },
    hAxis: {
      title: 'Time',
    },
    seriesType: 'line',
    series: {
      0: { color: 'green', pointSize: '5' },
      1: { color: '#1e90ff', lineDashStyle: [3, 3], pointSize: '5' },
      2: { type: 'bars', color: 'grey' },
    },
  };
  width = 1500;
  height = 400;
  chartType: ChartType = ChartType.ComboChart;
}
