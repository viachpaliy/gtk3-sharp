using Gdk;
using GLib;
using System;

namespace Gtk3
{
	public class DeleteEventArgs : SignalArgs
	{
		//
		// Properties
		//
		public Event Event {
			get {
				return (Event)base.Args [0];
			}
		}
	}
}

