using GLib;
using System;

namespace Gtk3
{
	//[GType (typeof(WindowTypeGType))]
	public enum WindowType
	{
		/// <summary>
		/// A regular window, such as a dialog.
		/// </summary>
		Toplevel,
		/// <summary>
		/// A special window such as a tooltip.
		/// </summary>
		Popup
	}
}
