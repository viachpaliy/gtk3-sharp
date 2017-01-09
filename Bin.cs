using GLib;
using System;
using System.Runtime.InteropServices;

namespace Gtk3
{
	public class Bin : Container
	{
		//
		// Constructors
		//
		public Bin (IntPtr raw) : base (raw)
		{
		}

		protected Bin () : base (IntPtr.Zero)
		{
		}


		// Import native function
		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_bin_get_child (IntPtr raw);

		//Method
		public Widget GetChild()
		{
			IntPtr o = Bin.gtk_bin_get_child (base.Handle);
			return GLib.Object.GetObject (o) as Widget;
		}

	}

}