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
	/// Indicated the relief to be drawn around a Gtk3.Button.
	/// </summary>
	public enum ReliefStyle
	{
		/// <summary>
		/// Draw a normal relief.
		/// </summary>
		Normal,//GTK_RELIEF_NORMAL
		/// <summary>
		/// A half relief. Deprecated in 3.14, does the same as ReliefStyle.Normal .
		/// </summary>
		Half,//GTK_RELIEF_HALF
		/// <summary>
		/// No relief.
		/// </summary>
		None//GTK_RELIEF_NONE
	}
}

