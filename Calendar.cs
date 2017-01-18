using GLib;
using System;
using System.Runtime.InteropServices;

namespace Gtk3
{
	public class Calendar : Widget
	{
		//
		// Static Methods
		//
		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_calendar_new ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_calendar_select_month (IntPtr raw, uint month, uint year);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_calendar_select_day (IntPtr raw, uint day);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_calendar_mark_day (IntPtr raw, uint day);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_calendar_unmark_day (IntPtr raw, uint day);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_calendar_get_day_is_marked (IntPtr raw, uint day);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_calendar_clear_marks (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_calendar_get_display_options (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_calendar_set_display_options (IntPtr raw, int flags);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_calendar_get_date (IntPtr raw, uint year, uint month, uint day);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_calendar_get_detail_width_chars (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_calendar_set_detail_width_chars (IntPtr raw, int chars);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_calendar_get_detail_height_rows (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_calendar_set_detail_height_rows (IntPtr raw, int rows);

		//
		// Constructors
		//

		public Calendar()
		{
			this.Raw = Calendar.gtk_calendar_new ();
		}

		public Calendar(IntPtr raw):base(raw)
		{
		}

		//
		//
		//


	}

}
