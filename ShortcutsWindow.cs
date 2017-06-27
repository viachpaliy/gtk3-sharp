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
	///Toplevel which shows help for shortcuts.
	/// </summary>
	public class ShortcutsWindow : Window
	{
		#region Properties
	
		/// <summary>
		/// The name of the section to show.
		/// </summary>
		[Property ("section-name")]
		public string SectionName {
			get {
				GLib.Value property = base.GetProperty ("section-name");
				string result = (string)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("section-name", val);
				val.Dispose ();
			}
		}



		/// <summary>
		/// The view name by which to filter the contents.
		/// </summary>
		[Property ("view-name")]
		public string ViewName {
			get {
				GLib.Value property = base.GetProperty ("view-name");
				string result = (string)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("view-name", val);
				val.Dispose ();
			}
		}

		#endregion

		#region Events

		/// <summary>
		/// This event is raised when the user uses a keybinding to close the window.
		/// </summary>
		[Signal ("close")]
		public event EventHandler Close {
			add {
				Signal signal = Signal.Lookup (this, "close");
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "close");
				signal.RemoveDelegate (value);
			}
		}

		/// <summary>
		/// This event is raised when the user uses a keybinding to start a search.
		/// </summary>
		[Signal ("search")]
		public event EventHandler Search {
			add {
				Signal signal = Signal.Lookup (this, "search");
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "search");
				signal.RemoveDelegate (value);
			}
		}

		#endregion

		#region Constructors

		/// <summary>
		///Internal constructor.Constructs the object from a C-based pointer.
		/// </summary>
		/// <param name="raw">The raw GObject reference associated with this object.</param>
		public ShortcutsWindow (IntPtr raw) : base (raw)
		{
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected ShortcutsWindow () : base (IntPtr.Zero){
		}

		#endregion


	}
}

