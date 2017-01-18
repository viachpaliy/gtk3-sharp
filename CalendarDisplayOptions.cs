using System;

namespace Gtk3
{
	public enum CalendarDisplayOptions
	{
		ShowHeading,//GTK_CALENDAR_SHOW_HEADING	Specifies that the month and year should be displayed.

		ShowDayNames,//GTK_CALENDAR_SHOW_DAY_NAMES	Specifies that three letter day descriptions should be present.

		NoMonthChange,//GTK_CALENDAR_NO_MONTH_CHANGE  Prevents the user from switching months with the calendar.

		ShowWeekNumbers,//GTK_CALENDAR_SHOW_WEEK_NUMBERS	Displays each week numbers of the current year, down the left side of the calendar.

		ShowDetails//GTK_CALENDAR_SHOW_DETAILS 	Just show an indicator, not the full details text when details are provided. 

	}
}

