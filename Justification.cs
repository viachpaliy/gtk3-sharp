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
	/// Used for justifying the text inside a Gtk3.Label widget. 
	/// </summary>
	public enum Justification
	{
		/// <summary>
		/// The text is placed at the left edge of the label.
		/// </summary>
		Left,//GTK_JUSTIFY_LEFT
		/// <summary>
		/// The text is placed at the right edge of the label.
		/// </summary>
		Right,//GTK_JUSTIFY_RIGHT
		/// <summary>
		/// The text is placed in the center of the label.
		/// </summary>
		Center,//GTK_JUSTIFY_CENTER
		/// <summary>
		///The text is placed is distributed across the label.
		/// </summary>
		Fill//GTK_JUSTIFY_FILL	
	}
}

