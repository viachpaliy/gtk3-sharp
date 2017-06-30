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
	public enum ScrollStep
	{
		/// <summary>
		/// Scroll in steps.
		/// </summary>
		Steps,//GTK_SCROLL_STEPS
		/// <summary>
		/// Scroll by pages.
		/// </summary>
		Pages,//GTK_SCROLL_PAGES
		/// <summary>
		/// Scroll to ends.
		/// </summary>
		Ends,//GTK_SCROLL_ENDS
		/// <summary>
		/// Scroll in horizontal steps.
		/// </summary>
		HorizontalSteps,//GTK_SCROLL_HORIZONTAL_STEPS
		/// <summary>
		/// Scroll by horizontal pages.
		/// </summary>
		HorizontalPages,//GTK_SCROLL_HORIZONTAL_PAGES
		/// <summary>
		/// Scroll to the horizontal ends.
		/// </summary>
		HorizontalEnds//GTK_SCROLL_HORIZONTAL_ENDS 	
	}
}

