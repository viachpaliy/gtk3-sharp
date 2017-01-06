// Gtk3.Application.cs - GTK Main Event Loop class implementation
//
//This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, US

namespace Gtk3 {

	using System;
	using System.Reflection;
	using System.Runtime.InteropServices;
	using System.Threading;
	using Gdk;
	using GLib;

	public partial class Application {
		
		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_init (ref int argc, ref IntPtr argv);

		public static void Init ()
		{
			//SetPrgname ();
			IntPtr argv = new IntPtr(0);
			int argc = 0;

			gtk_init (ref argc, ref argv);

			//SynchronizationContext.SetSynchronizationContext (new GLib.GLibSynchronizationContext ());
		}

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_main ();

		public static void Run ()
		{
			gtk_main ();
		}

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_main_iteration ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_main_iteration_do (bool blocking);

		public static void RunIteration ()
		{
			gtk_main_iteration ();
		}

		public static bool RunIteration (bool blocking)
		{
			return gtk_main_iteration_do (blocking);
		}

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_main_quit ();

		public static void Quit ()
		{
			gtk_main_quit ();
		}




	}
}