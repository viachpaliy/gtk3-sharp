using System;

namespace Gtk3
{
	public enum DeleteType
	{
		GTK_DELETE_CHARS,	//Delete characters.

		GTK_DELETE_WORD_ENDS,	//Delete only the portion of the word to the left/right of cursor if we’re in the middle of a word.

		GTK_DELETE_WORDS,		//Delete words.

		GTK_DELETE_DISPLAY_LINES,	//Delete display-lines. Display-lines refers to the visible lines, with respect to to the current line breaks.
									//As opposed to paragraphs, which are defined by line breaks in the input.

		GTK_DELETE_DISPLAY_LINE_ENDS,	//Delete only the portion of the display-line to the left/right of cursor.

		GTK_DELETE_PARAGRAPH_ENDS,		//Delete to the end of the paragraph. Like C-k in Emacs (or its reverse).

		GTK_DELETE_PARAGRAPHS, 		//Delete entire line. Like C-k in pico.

		GTK_DELETE_WHITESPACE     //Delete only whitespace. Like M-\ in Emacs.
	}
}

