using GLib;
using System;

namespace Gtk3
{
	public class ChildNotifiedArgs : SignalArgs
	{
		//
		// Properties
		//
		public IntPtr Pspec {
			get {
				return (IntPtr)base.Args [0];
			}
		}
	}
}

