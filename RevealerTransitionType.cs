using System;

namespace Gtk3
{
	public enum RevealerTransitionType
	{
		GTK_REVEALER_TRANSITION_TYPE_NONE,	//No transition

		GTK_REVEALER_TRANSITION_TYPE_CROSSFADE,	//Fade in

		GTK_REVEALER_TRANSITION_TYPE_SLIDE_RIGHT,	//Slide in from the left

		GTK_REVEALER_TRANSITION_TYPE_SLIDE_LEFT,	//Slide in from the right

		GTK_REVEALER_TRANSITION_TYPE_SLIDE_UP,	//	Slide in from the bottom

		GTK_REVEALER_TRANSITION_TYPE_SLIDE_DOWN	//Slide in from the top
	}
}

