using System;

namespace Gtk3
{
	public enum ResizeMode
	{
		GTK_RESIZE_PARENT,		//Pass resize request to the parent

		GTK_RESIZE_QUEUE,		//Queue resizes on this widget

		GTK_RESIZE_IMMEDIATE	//Resize immediately. Deprecated.

	}
}

