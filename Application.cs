// Copyright (c) 2017 Author : Viacheslav Paliy
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Gdk;
using GLib;

namespace Gtk3 {

	/// <summary>
	/// Application class.
	/// </summary>
	public  class Application {

		#region Private Static Methods
		
		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_init (ref int argc, ref IntPtr argv);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_main ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_main_iteration ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_main_iteration_do (bool blocking);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_main_quit ();


		#endregion

		public static void Init ()
		{
			//SetPrgname ();
			IntPtr argv = new IntPtr(0);
			int argc = 0;
			//string[] arg = new string[]{ };
			//Gdk.Global.InitCheck (ref arg);
			gtk_init (ref argc, ref argv);

			//SynchronizationContext.SetSynchronizationContext (new GLib.GLibSynchronizationContext ());
		}


		public static void Run ()
		{
			gtk_main ();
		}

	

		public static void RunIteration ()
		{
			gtk_main_iteration ();
		}

		public static bool RunIteration (bool blocking)
		{
			return gtk_main_iteration_do (blocking);
		}

	

		public static void Quit ()
		{
			gtk_main_quit ();
		}




	}
}