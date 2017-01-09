using System;

namespace Gtk3
{
	public enum MovementStep
	{
		GTK_MOVEMENT_LOGICAL_POSITIONS,		//Move forward or back by graphemes

		GTK_MOVEMENT_VISUAL_POSITIONS,		//Move left or right by graphemes

		GTK_MOVEMENT_WORDS,		//Move forward or back by words

		GTK_MOVEMENT_DISPLAY_LINES,		//Move up or down lines (wrapped lines)

		GTK_MOVEMENT_DISPLAY_LINE_ENDS,		//Move to either end of a line

		GTK_MOVEMENT_PARAGRAPHS,		//Move up or down paragraphs (newline-ended lines)

		GTK_MOVEMENT_PARAGRAPH_ENDS,	//Move to either end of a paragraph

		GTK_MOVEMENT_PAGES,		//Move by pages

		GTK_MOVEMENT_BUFFER_ENDS,	//Move to ends of the buffer

		GTK_MOVEMENT_HORIZONTAL_PAGES		//Move horizontally by pages
	}
}

