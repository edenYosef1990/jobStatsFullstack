export interface DateDay {
	day: number,
	month: number,
	year: number
}

export function DateDayToDate(dateDay: DateDay): Date{
	return new Date(dateDay.year,dateDay.month,dateDay.day);
}

export function DateToDayDate(date:Date): DateDay {
	return {year: date.getFullYear(), month: date.getMonth(), day: date.getDate()};
}
