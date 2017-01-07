using System;

namespace Gtk3
{
	public delegate bool ButtonPressEventHandler (object o, ButtonPressEventArgs args);

	//Return TRUE to stop other handlers from being invoked for the event. 
	//Return FALSE to propagate the event further.
}
