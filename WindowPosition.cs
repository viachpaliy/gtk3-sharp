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
	/// Window placement can be influenced using this enumeration.
	/// </summary>
	public enum WindowPosition
	{
		/// <summary>
		/// No influence is made on placement.
		/// </summary>
		None,//GTK_WIN_POS_NONE
		/// <summary>
		/// Windows should be placed in the center of the screen.
		/// </summary>
		Center,//GTK_WIN_POS_CENTER
		/// <summary>
		///Windows should be placed at the current mouse position.
		/// </summary>
		Mouse,//GTK_WIN_POS_MOUSE
		/// <summary>
		/// Keep window centered as it changes size, etc.
		/// </summary>
		CenterAlways,//GTK_WIN_POS_CENTER_ALWAYS
		/// <summary>
		/// Center the window on its transient parent.
		/// </summary>
		CenterOnParent//GTK_WIN_POS_CENTER_ON_PARENT
	}
}

