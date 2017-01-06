using GLib;
using System;

namespace Gtk3
{
	[GType (typeof(TextDirectionGType))]
	public enum TextDirection
	{
		None,
		Ltr,
		Rtl
	}
}

