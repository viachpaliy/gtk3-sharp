using System;

namespace Gtk3
{
	public enum WindowPosition
	{
		GTK_WIN_POS_NONE,	//No influence is made on placement.

		GTK_WIN_POS_CENTER,	//Windows should be placed in the center of the screen.

		GTK_WIN_POS_MOUSE,	//Windows should be placed at the current mouse position.

		GTK_WIN_POS_CENTER_ALWAYS,	//Keep window centered as it changes size, etc.

		GTK_WIN_POS_CENTER_ON_PARENT	//Center the window on its transient parent.
	}
}

