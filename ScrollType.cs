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
	/// <summary>
	/// Scrolling types.
	/// </summary>
	public enum ScrollType
	{
		/// <summary>
		/// No scrolling.
		/// </summary>
		None,//GTK_SCROLL_NONE
		/// <summary>
		/// Jump to new location.
		/// </summary>
		Jump,//GTK_SCROLL_JUMP 
		/// <summary>
		/// Step backward.
		/// </summary>
		StepBackward,//GTK_SCROLL_STEP_BACKWARD
		/// <summary>
		/// Step forward.
		/// </summary>
		StepForward,//GTK_SCROLL_STEP_FORWARD	
		/// <summary>
		/// Page backward.
		/// </summary>
		PageBackward,//GTK_SCROLL_PAGE_BACKWARD
		/// <summary>
		/// Page forward.
		/// </summary>
		PageForward,//GTK_SCROLL_PAGE_FORWARD	
		/// <summary>
		/// Step up.
		/// </summary>
		StepUp,//GTK_SCROLL_STEP_UP	
		/// <summary>
		/// Step down.
		/// </summary>
		StepDown,//GTK_SCROLL_STEP_DOWN
		/// <summary>
		/// Page up.
		/// </summary>
		PageUp,//GTK_SCROLL_PAGE_UP
		/// <summary>
		/// Page down.
		/// </summary>
		PageDown,//GTK_SCROLL_PAGE_DOWN
		/// <summary>
		/// Step to the left.
		/// </summary>
		StepLeft,//GTK_SCROLL_STEP_LEFT
		/// <summary>
		/// Step to the right.
		/// </summary>
		StepRight,//GTK_SCROLL_STEP_RIGHT
		/// <summary>
		///Page to the left.
		/// </summary>
		PageLeft,//GTK_SCROLL_PAGE_LEFT
		/// <summary>
		/// Page to the right.
		/// </summary>
		PageRight,//GTK_SCROLL_PAGE_RIGHT
		/// <summary>
		/// Scroll to start.
		/// </summary>
		Start,//GTK_SCROLL_START
		/// <summary>
		/// Scroll to end.
		/// </summary>
		End//GTK_SCROLL_END
	}
}

