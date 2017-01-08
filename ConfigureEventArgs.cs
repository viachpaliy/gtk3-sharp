using Gdk;
using GLib;
using System;

namespace Gtk3
{
	public class ConfigureEventArgs : SignalArgs
	{
		//
		// Properties
		//
		public EventConfigure Event {
			get {
				return (EventConfigure)base.Args [0];
			}
		}
	}
}
