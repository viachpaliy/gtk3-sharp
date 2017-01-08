using Gdk;
using GLib;
using Pango;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Gtk3{

	public class StyleContext : GLib.Object {

		#region Gtk+ native functions

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_style_context_add_provider_for_screen (IntPtr screen, IntPtr provider, uint priority);

		#endregion


	}
}