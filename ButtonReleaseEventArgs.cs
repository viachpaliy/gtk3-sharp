using Gdk;
using GLib;
using System;

namespace Gtk3
{
	public class ButtonReleaseEventArgs : SignalArgs
	{
		//
		// Properties
		//
		public EventButton Event {
			get {
				return (EventButton)base.Args [0];
			}
		}
	}
}
