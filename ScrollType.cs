using System;

namespace Gtk3
{
	public enum ScrollType
	{
		GTK_SCROLL_NONE,  //No scrolling.

		GTK_SCROLL_JUMP, //Jump to new location.

		GTK_SCROLL_STEP_BACKWARD,	//Step backward.

		GTK_SCROLL_STEP_FORWARD,  //	Step forward.

		GTK_SCROLL_PAGE_BACKWARD, 	//Page backward.

		GTK_SCROLL_PAGE_FORWARD, //	Page forward.

		GTK_SCROLL_STEP_UP, //	Step up.

		GTK_SCROLL_STEP_DOWN,	//Step down.

		GTK_SCROLL_PAGE_UP,		//Page up.

		GTK_SCROLL_PAGE_DOWN, 	//Page down.

		GTK_SCROLL_STEP_LEFT,	//Step to the left.

		GTK_SCROLL_STEP_RIGHT,  //Step to the right.

		GTK_SCROLL_PAGE_LEFT,  //Page to the left.

		GTK_SCROLL_PAGE_RIGHT,	//Page to the right.

		GTK_SCROLL_START,		//Scroll to start.

		GTK_SCROLL_END		//Scroll to end.
	}
}

