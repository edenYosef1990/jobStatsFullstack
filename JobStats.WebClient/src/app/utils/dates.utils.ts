import {DateDay, DateDayToDate, DateToDayDate} from "../types/dateDay";

export function generateDataRange(firstDay: DateDay, lastDay: DateDay): DateDay[] {
  let datesRange: DateDay[] = [];
  let firstAsDate = DateDayToDate(firstDay);
  let lastAsDate = DateDayToDate(lastDay);
  let currentDate = firstAsDate;
  while (currentDate <= lastAsDate) {
    datesRange.push(DateToDayDate(currentDate));
    let newDate = new Date(currentDate);
    newDate.setDate(newDate.getDate() + 1)
    currentDate = newDate;
  }
  return datesRange;
}

export function dateDayToString(date: DateDay): string {
  return (
    `${date.year.toString().padStart(4, '0')}` +
    `${date.month.toString().padStart(2, '0')}` +
    `${date.day.toString().padStart(2, '0')}`
  );
}
