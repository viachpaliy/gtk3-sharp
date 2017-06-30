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

namespace Gtk3sharp
{
	/// <summary>
	/// Describes a widget state.Widget states are used to match the widget against CSS pseudo-classes.  
	/// </summary>
	public enum StateFlags
	{
		/// <summary>
		/// State during normal operation.
		/// </summary>
		Normal,//GTK_STATE_FLAG_NORMAL
		/// <summary>
		///Widget is active.
		/// </summary>
		Active,//GTK_STATE_FLAG_ACTIVE
		/// <summary>
		///Widget has a mouse pointer over it.
		/// </summary>
		Prelight,//GTK_STATE_FLAG_PRELIGHT
		/// <summary>
		/// Widget is selected.
		/// </summary>
		Selected,//GTK_STATE_FLAG_SELECTED
		/// <summary>
		/// Widget is insensitive.
		/// </summary>
		Insensitive,//GTK_STATE_FLAG_INSENSITIVE
		/// <summary>
		/// Widget is inconsistent.
		/// </summary>
		Inconsistent,//GTK_STATE_FLAG_INCONSISTENT
		/// <summary>
		/// Widget has the keyboard focus.
		/// </summary>
		Focused,//GTK_STATE_FLAG_FOCUSED
		/// <summary>
		/// Widget is in a background toplevel window.
		/// </summary>
		Backdrop,//GTK_STATE_FLAG_BACKDROP
		/// <summary>
		/// Widget is in left-to-right text direction. Since 3.8
		/// </summary>
		DirLtr,//GTK_STATE_FLAG_DIR_LTR
		/// <summary>
		/// Widget is in right-to-left text direction. Since 3.8
		/// </summary>
		DirRtl,//GTK_STATE_FLAG_DIR_RTL
		/// <summary>
		/// Widget is a link. Since 3.12
		/// </summary>
		Link,//GTK_STATE_FLAG_LINK
		/// <summary>
		/// The location the widget points to has already been visited. Since 3.12
		/// </summary>
		Visited,//GTK_STATE_FLAG_VISITED
		/// <summary>
		/// Widget is checked. Since 3.14
		/// </summary>
		Checked,//GTK_STATE_FLAG_CHECKED
		/// <summary>
		/// Widget is highlighted as a drop target for DND. Since 3.20
		/// </summary>
		DropActive//GTK_STATE_FLAG_DROP_ACTIVE
	}
}

