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
	public enum Align
	{
		/// <summary>
		/// stretch to fill all space if possible, center if no meaningful way to stretch
		/// </summary>
		Fill,//GTK_ALIGN_FILL 
		/// <summary>
		/// snap to left or top side, leaving space on right or bottom
		/// </summary>
		Start,//GTK_ALIGN_START 
		/// <summary>
		/// snap to right or bottom side, leaving space on left or top
		/// </summary>
		End,//GTK_ALIGN_END  
		/// <summary>
		/// center natural width of widget inside the allocation
		/// </summary>
		Center,//GTK_ALIGN_CENTER	
		/// <summary>
		/// align the widget according to the baseline.
		/// </summary>
		Baseline//GTK_ALIGN_BASELINE	 
	}
}

