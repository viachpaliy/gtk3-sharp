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
	/// Describes which edge of a widget a certain feature is positioned at,
	///  e.g. the tabs of a Gtk3.Notebook, the handle of a Gtk3.HandleBox or the label of a Gtk3.Scale.
	/// </summary>
	public enum PositionType
	{
		/// <summary>
		/// The feature is at the left edge.
		/// </summary>
		Left,//GTK_POS_LEFT 	
		/// <summary>
		/// The feature is at the right edge.
		/// </summary>
		Right,//GTK_POS_RIGHT	
		/// <summary>
		/// The feature is at the top edge.
		/// </summary>
		Top,//GTK_POS_TOP	
		/// <summary>
		/// The feature is at the bottom edge.
		/// </summary>
		Bottom//GTK_POS_BOTTOM	
	}
}

