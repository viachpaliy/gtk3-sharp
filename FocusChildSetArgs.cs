﻿using GLib;
using System;

namespace Gtk3
{
	public class FocusChildSetArgs : SignalArgs
	{
		//
		// Properties
		//
		public Widget Widget {
			get {
				return (Widget)base.Args [0];
			}
		}
	}
}
