using GLib;
using System;

namespace Gtk3
{
	public class CanActivateAccelArgs : SignalArgs
	{
		//
		// Properties
		//
		public uint SignalId {
			get{
				return (uint)base.Args [0];
			}
		}



	}

}
