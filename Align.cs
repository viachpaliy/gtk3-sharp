using System;

namespace Gtk3
{
	public enum Align
	{
		Fill,//GTK_ALIGN_FILL stretch to fill all space if possible, center if no meaningful way to stretch

		Start,//GTK_ALIGN_START snap to left or top side, leaving space on right or bottom

		End,//GTK_ALIGN_END  snap to right or bottom side, leaving space on left or top

		Center,//GTK_ALIGN_CENTER	center natural width of widget inside the allocation

		Baseline//GTK_ALIGN_BASELINE	align the widget according to the baseline. Since 3.10.
	}
}

