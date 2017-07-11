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
using GLib;
using System;

namespace Gtk3
{
	/// <summary>
	/// The Widget.CanActivateAccel event invokes Gtk3.CanActivateAccelHandler delegates
	///  which pass event data via this class.
	/// </summary>
	public class CanActivateAccelArgs : SignalArgs
	{
		
		/// <summary>
		/// The ID of a signal.This signal is present to allow applications 
		/// and derived widgets to override the default Gtk3.Widget handling 
		/// for determining whether an accelerator can be activated.
		/// </summary>
		/// <value>The signal identifier.</value>
		public uint SignalId {
			get{
				return (uint)base.Args [0];
			}
		}



	}

}
