using System;

namespace Gtk3
{
	public enum GtkAlign
	{
		GTK_ALIGN_FILL,		//stretch to fill all space if possible, center if no meaningful way to stretch

		GTK_ALIGN_START,	//snap to left or top side, leaving space on right or bottom

		GTK_ALIGN_END,		//snap to right or bottom side, leaving space on left or top

		GTK_ALIGN_CENTER,	//center natural width of widget inside the allocation

		GTK_ALIGN_BASELINE	//align the widget according to the baseline. Since 3.10.
	}
}

