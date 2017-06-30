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
	/// Used to change the appearance of an outline typically provided by a Gtk3.Frame.
	/// </summary>
	public enum ShadowType
	{
		/// <summary>
		/// No outline.
		/// </summary>
		None,//GTK_SHADOW_NONE
		/// <summary>
		/// The outline is bevelled inwards.
		/// </summary>
		In,//GTK_SHADOW_IN
		/// <summary>
		/// The outline is bevelled outwards like a button.
		/// </summary>
		Out,//GTK_SHADOW_OUT
		/// <summary>
		/// The outline has a sunken 3d appearance.
		/// </summary>
		EthcedIn,//GTK_SHADOW_ETCHED_IN
		/// <summary>
		/// The outline has a raised 3d appearance.
		/// </summary>
		EtchedOut//GTK_SHADOW_ETCHED_OUT
	}
}

