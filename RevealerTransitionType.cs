using System;

namespace Gtk3
{
	public enum RevealerTransitionType
	{
		None,//GTK_REVEALER_TRANSITION_TYPE_NONE  No transition

		Crossfade,//GTK_REVEALER_TRANSITION_TYPE_CROSSFADE	Fade in

		SlideRight,//GTK_REVEALER_TRANSITION_TYPE_SLIDE_RIGHT   Slide in from the left

		SlideLeft,//GTK_REVEALER_TRANSITION_TYPE_SLIDE_LEFT  Slide in from the right

		SlideUp,//GTK_REVEALER_TRANSITION_TYPE_SLIDE_UP		Slide in from the bottom

		SlideDown//GTK_REVEALER_TRANSITION_TYPE_SLIDE_DOWN	S lide in from the top
	}
}

