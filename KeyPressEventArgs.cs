using Gdk;
using GLib;
using System;

namespace Gtk3
{
	public class KeyPressEventArgs : SignalArgs
	{
		//
		// Properties
		//
		public EventKey Event {
			get {
				return (EventKey)base.Args [0];
			}
		}
	}
}
