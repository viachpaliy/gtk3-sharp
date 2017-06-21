using System;

namespace Gtk3
{
	public enum DeleteType
	{
		DeleteChars,	//Delete characters.

		DeleteWordEnds,	//Delete only the portion of the word to the left/right of cursor if we’re in the middle of a word.

		DeleteWords,		//Delete words.

		DeleteDisplayLines,	//Delete display-lines. Display-lines refers to the visible lines, with respect to to the current line breaks.
									//As opposed to paragraphs, which are defined by line breaks in the input.

		DeleteDisplayLineEnds,	//Delete only the portion of the display-line to the left/right of cursor.

		DeleteParagraphEnds,		//Delete to the end of the paragraph. Like C-k in Emacs (or its reverse).

		DeleteParagraphs, 		//Delete entire line. Like C-k in pico.

		DeleteWhitespace     //Delete only whitespace. Like M-\ in Emacs.
	}
}

