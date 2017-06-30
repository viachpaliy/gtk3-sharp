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
	public enum MovementStep
	{
		/// <summary>
		/// Move forward or back by graphemes.
		/// </summary>
		LogicalPositions,//GTK_MOVEMENT_LOGICAL_POSITIONS
		/// <summary>
		///Move left or right by graphemes.
		/// </summary>
		VisualPositions,//GTK_MOVEMENT_VISUAL_POSITIONS
		/// <summary>
		/// Move forward or back by words.
		/// </summary>
		Words,//GTK_MOVEMENT_WORDS
		/// <summary>
		/// Move up or down lines (wrapped lines).
		/// </summary>
		DisplayLines,//GTK_MOVEMENT_DISPLAY_LINES
		/// <summary>
		/// Move to either end of a line.
		/// </summary>
		DisplayLineEnds,//GTK_MOVEMENT_DISPLAY_LINE_ENDS
		/// <summary>
		/// Move up or down paragraphs (newline-ended lines).
		/// </summary>
		Paragrphs,//GTK_MOVEMENT_PARAGRAPHS
		/// <summary>
		/// Move to either end of a paragraph.
		/// </summary>
		ParagraphEnds,//GTK_MOVEMENT_PARAGRAPH_ENDS
		/// <summary>
		/// Move by pages.
		/// </summary>
		Pages,//GTK_MOVEMENT_PAGES
		/// <summary>
		/// Move to ends of the buffer.
		/// </summary>
		BufferEnds,//GTK_MOVEMENT_BUFFER_ENDS
		/// <summary>
		///Move horizontally by pages.
		/// </summary>
		HorizontalPages//GTK_MOVEMENT_HORIZONTAL_PAGES
	}
}

