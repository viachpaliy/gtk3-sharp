using System;
using System.Runtime.InteropServices;
using GLib;
using Gdk;

namespace Gtk3{

	public partial class Window:Widget{

		#region import native functions

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_new (int type);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_title (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_title (IntPtr raw, IntPtr title);

		#endregion

		#region Properties

		[Property ("title")]
		public string Title {
			get {
				IntPtr ptr = Window.gtk_window_get_title (base.Handle);
				return Marshaller.Utf8PtrToString (ptr);
			}
			set {
				IntPtr intPtr = Marshaller.StringToPtrGStrdup (value);
				Window.gtk_window_set_title (base.Handle, intPtr);
				Marshaller.Free (intPtr);
			}
		}

		#endregion

		public Window (WindowType type)
		{
			this.Raw = Window.gtk_window_new ((int)type);
		}

		public Window (IntPtr raw) : base (raw)
		{
		}

	}



}
