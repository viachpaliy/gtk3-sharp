using System;

namespace Gtk3sharp
{
	public enum StateFlags
	{
		GTK_STATE_FLAG_NORMAL,		//State during normal operation.

		GTK_STATE_FLAG_ACTIVE,		//Widget is active.

		GTK_STATE_FLAG_PRELIGHT,	//Widget has a mouse pointer over it.

		GTK_STATE_FLAG_SELECTED,	//Widget is selected.

		GTK_STATE_FLAG_INSENSITIVE, 	//Widget is insensitive.

		GTK_STATE_FLAG_INCONSISTENT,	//Widget is inconsistent.

		GTK_STATE_FLAG_FOCUSED,		//Widget has the keyboard focus.

		GTK_STATE_FLAG_BACKDROP,	//Widget is in a background toplevel window.

		GTK_STATE_FLAG_DIR_LTR,		//Widget is in left-to-right text direction. Since 3.8

		GTK_STATE_FLAG_DIR_RTL,		//Widget is in right-to-left text direction. Since 3.8

		GTK_STATE_FLAG_LINK,		//Widget is a link. Since 3.12

		GTK_STATE_FLAG_VISITED,		//The location the widget points to has already been visited. Since 3.12

		GTK_STATE_FLAG_CHECKED,		//Widget is checked. Since 3.14

		GTK_STATE_FLAG_DROP_ACTIVE //Widget is highlighted as a drop target for DND. Since 3.20
	}
}

