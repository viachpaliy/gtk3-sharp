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

		#region Static methods
		public static void AddProviderForScreen(CssProvider provider)
		{
			Gdk.Display display = Gdk.Display.Default;
			Gdk.Screen screen = display.DefaultScreen;
			Gtk3.StyleContext.gtk_style_context_add_provider_for_screen (screen.Handle, provider.Handle,
				Gtk3.Global.GTK_STYLE_PROVIDER_PRIORITY_APPLICATION);
		}

		public static void AddProviderForScreen(CssProvider provider,Gtk3.Window window)
		{
			
			Gdk.Screen screen = window.Screen;
			Gtk3.StyleContext.gtk_style_context_add_provider_for_screen (screen.Handle, provider.Handle,
				Gtk3.Global.GTK_STYLE_PROVIDER_PRIORITY_APPLICATION);
		}

		#endregion



	}
}