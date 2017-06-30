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
	///  Determines the directions in which the size group affects the requested sizes of its component widgets.
	/// </summary>
	public enum SizeGroupMode
	{
	/// <summary>
	/// group has no effect		  	/// <summary>
	None,// GTK_SIZE_GROUP_NONE
	/// <summary>
	/// group affects horizontal requisition
	/// <summary>
	Horizontal,// GTK_SIZE_GROUP_HORIZONTAL
	/// <summary>
	/// group affects vertical requisition 
	/// <summary>
	Vertical,// GTK_SIZE_GROUP_VERTICAL
	///<summary>
	///group affects both horizontal and vertical requisition 
	///<summary>
	Both// GTK_SIZE_GROUP_BOTH
	}
}




