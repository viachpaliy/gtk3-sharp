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
using System.Runtime.InteropServices;

namespace Gtk3
{
	public class Button : Bin
	{

		#region Constructors
		/// <summary>
		///Internal constructor.Constructs the object from a C-based pointer.
		/// </summary>
		/// <param name="raw">The raw GObject reference associated with this object.</param>	
			public Button (IntPtr raw) : base (raw)
		{
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Button () : base (IntPtr.Zero)
		{
			this.Raw = Button.gtk_button_new ();
		}



		public Button (string label) : base (IntPtr.Zero)
		{
			IntPtr intPtr = Marshaller.StringToPtrGStrdup (label);
			this.Raw = Button.gtk_button_new_with_label (intPtr);
			Marshaller.Free (intPtr);
		}

		public Button (string iconName, IconSize size)
		{
			IntPtr intPtr = Marshaller.StringToPtrGStrdup (iconName);
			this.Raw = Button.gtk_button_new_from_icon_name (intPtr, (int)size);
			Marshaller.Free (intPtr);
		}

		#endregion


		//
		// Properties
		//

		[Property ("always-show-image")]
		public bool AlwaysShowImage {
			get {
				return Button.gtk_button_get_always_show_image (base.Handle);
			}
			set {
				Button.gtk_button_set_always_show_image (base.Handle, value);
			}
		}

		[Property ("image")]
		public Widget Image {
			get {
				IntPtr o = Button.gtk_button_get_image (base.Handle);
				return GLib.Object.GetObject (o) as Widget;
			}
			set {
				Button.gtk_button_set_image (base.Handle, (value != null) ? value.Handle : IntPtr.Zero);
			}
		}


		[Property ("image-position")]
		public PositionType ImagePosition {
			get {
				return (PositionType)Button.gtk_button_get_image_position (base.Handle);
			}
			set {
				Button.gtk_button_set_image_position (base.Handle, (int)value);
			}
		}

		[Property ("label")]
		public string Label {
			get {
				IntPtr ptr = Button.gtk_button_get_label (base.Handle);
				return Marshaller.Utf8PtrToString (ptr);
			}
			set {
				IntPtr intPtr = Marshaller.StringToPtrGStrdup (value);
				Button.gtk_button_set_label (base.Handle, intPtr);
				Marshaller.Free (intPtr);
			}
		}

		[Property ("relief")]
		public ReliefStyle Relief {
			get {
				return (ReliefStyle)Button.gtk_button_get_relief (base.Handle);
			}
			set {
				Button.gtk_button_set_relief (base.Handle, (int)value);
			}
		}

		[Property ("use-underline")]
		public bool UseUnderline {
			get {
				return Button.gtk_button_get_use_underline (base.Handle);
			}
			set {
				Button.gtk_button_set_use_underline (base.Handle, value);
			}
		}
		//
		// Methods
		//
		public void Click ()
		{
			Button.gtk_button_clicked (base.Handle);
		}
		//
		// Events
		//
		[Signal ("activate")]
		//The ::activate signal on GtkButton is an action signal
		//and emitting it causes the button to animate press then release.
		public event EventHandler Activated {
			add {
				Signal signal = Signal.Lookup (this, "activate");
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "activate");
				signal.RemoveDelegate (value);
			}
		}

		[Signal ("clicked")]
		//Emitted when the button has been activated (pressed and released).
		public event EventHandler Clicked {
			add {
				Signal signal = Signal.Lookup (this, "clicked");
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "clicked");
				signal.RemoveDelegate (value);
			}
		}


		//
		// Static Methods
		//
		

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_button_clicked (IntPtr raw);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_button_get_always_show_image (IntPtr raw);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_button_get_image (IntPtr raw);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_button_get_image_position (IntPtr raw);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_button_get_label (IntPtr raw);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_button_get_relief (IntPtr raw);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_button_get_use_underline (IntPtr raw);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_button_new ();

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_button_new_with_label (IntPtr label);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_button_new_with_mnemonic (IntPtr label);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_button_new_from_icon_name (IntPtr icon_name, int size);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_button_set_always_show_image (IntPtr raw, bool always_show);
	
		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_button_set_image (IntPtr raw, IntPtr image);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_button_set_image_position (IntPtr raw, int position);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_button_set_label (IntPtr raw, IntPtr label);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_button_set_relief (IntPtr raw, int newstyle);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_button_set_use_underline (IntPtr raw, bool use_underline);



	}


}
