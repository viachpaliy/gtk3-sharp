using System;

namespace Gtk3
{
	public enum SelectionMode
	{
		GTK_SELECTION_NONE,		//No selection is possible.

		GTK_SELECTION_SINGLE,	//Zero or one element may be selected.

		GTK_SELECTION_BROWSE,	//Exactly one element is selected. 

		GTK_SELECTION_MULTIPLE	//Any number of elements may be selected. 
	}
}

