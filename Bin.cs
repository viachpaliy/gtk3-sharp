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
using GLib;
using System;
using System.Runtime.InteropServices;

namespace Gtk3
{
	/// <summary>
	///  A container with just one child.
	/// </summary>
	public class Bin : Container
	{
		#region Constructors
		/// <summary>
		///Internal constructor.Constructs the object from a C-based pointer.
		/// </summary>
		/// <param name="raw">The raw GObject reference associated with this object.</param>
		public Bin (IntPtr raw) : base (raw)
		{
		}
		/// <summary>
		/// Default constructor.
		/// </summary>
		protected Bin () : base (IntPtr.Zero)
		{
		}

		#endregion

		#region Static Method

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_bin_get_child (IntPtr raw);

		#endregion

		#region Public Method
		/// <summary>
		/// Gets the child of the GtkBin, or NULL if the bin contains no child widget. 
		/// </summary>
		/// <returns>The child  of the GtkBin. </returns>
		public Widget GetChild()
		{
			IntPtr o = Bin.gtk_bin_get_child (base.Handle);
			return GLib.Object.GetObject (o) as Widget;
		}

		#endregion

	}

}