using GLib;
using System;
using System.Runtime.InteropServices;

namespace Gtk3
{
	public class Fixed : Container
	{

		//
		// Static Methods
		//
		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_fixed_new ();

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_fixed_put (IntPtr raw, IntPtr widget, int x, int y);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_fixed_move (IntPtr raw, IntPtr widget, int x, int y);

		//
		// Constructors
		//
		public Fixed (IntPtr raw) : base (raw)
		{
		}

		public Fixed () : base (IntPtr.Zero)
		{
			this.Raw = Fixed.gtk_fixed_new ();
		}

		//
		// Methods
		//
		public void Move (Widget widget, int x, int y)
		{
			Fixed.gtk_fixed_move (base.Handle, (widget != null) ? widget.Handle : IntPtr.Zero, x, y);
		}

		public void Put (Widget widget, int x, int y)
		{
			Fixed.gtk_fixed_put (base.Handle, (widget != null) ? widget.Handle : IntPtr.Zero, x, y);
		}

	}

}
