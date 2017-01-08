using System;

namespace Gtk3
{
	public delegate void ButtonReleaseEventHandler (object o, ButtonReleaseEventArgs args);

	//Return TRUE to stop other handlers from being invoked for the event. 
	//Return FALSE to propagate the event further.
}
