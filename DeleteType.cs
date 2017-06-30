// Copyright (c) 2017 Author : Viacheslav Paliy
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//
using System;

namespace Gtk3
{
	public enum DeleteType
	{
		/// <summary>
		/// Delete characters.
		/// </summary>
		DeleteChars,	//
		/// <summary>
		///Delete only the portion of the word to the left/right of cursor if we’re in the middle of a word.
		/// </summary>
		DeleteWordEnds,	//
		/// <summary>
		/// Delete words.
		/// </summary>
		DeleteWords,		//
		/// <summary>
		/// Delete display-lines. Display-lines refers to the visible lines, 
		/// with respect to to the current line breaks.
		///As opposed to paragraphs, which are defined by line breaks in the input.
		/// </summary>
		DeleteDisplayLines,	//
		/// <summary>
		/// Delete only the portion of the display-line to the left/right of cursor.
		/// </summary>
		DeleteDisplayLineEnds,	//
		/// <summary>
		/// Delete to the end of the paragraph. Like C-k in Emacs (or its reverse).
		/// </summary>
		DeleteParagraphEnds,		//
		/// <summary>
		/// Delete entire line. Like C-k in pico.
		/// </summary>
		DeleteParagraphs, 		//
		/// <summary>
		/// Delete only whitespace. Like M-\ in Emacs.
		/// </summary>
		DeleteWhitespace     //
	}
}

