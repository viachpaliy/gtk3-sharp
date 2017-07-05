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
using Gdk;
using GLib;
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Gtk3
{
	/// <summary>
	///  Base class for widgets which contain other widgets
	/// </summary>
	public class Container : Widget, IEnumerable
	{
		#region Private Static Methods

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_add (IntPtr raw, IntPtr widget);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_remove (IntPtr raw, IntPtr widget);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_add_with_properties (IntPtr raw, IntPtr child, IntPtr first_property_name, IntPtr var_args);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_check_resize (IntPtr raw);

//		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
//		private static extern void gtk_container_foreach (IntPtr raw, CallbackNative cb, IntPtr callback_data);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_get_children (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_get_path_for_child (IntPtr raw, IntPtr child);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_get_focus_child (IntPtr Raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_focus_child (IntPtr raw, IntPtr child);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_get_focus_hadjustment (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_focus_hadjustment (IntPtr raw, IntPtr adjustment);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_get_focus_vadjustment (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_focus_vadjustment (IntPtr raw, IntPtr adjustment);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_child_type (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_child_get (IntPtr raw, IntPtr child, IntPtr first_property_name,out IntPtr var_args);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_child_set (IntPtr raw, IntPtr child, IntPtr property_name, IntPtr var_args);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_child_get_property (IntPtr raw, IntPtr child, IntPtr property_name,out GLib.Value value);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_child_set_property (IntPtr raw, IntPtr child, IntPtr property_name, ref GLib.Value value);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_child_get_valist (IntPtr raw, IntPtr child, IntPtr first_property_name,out IntPtr var_args);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_child_set_valist (IntPtr raw, IntPtr child, IntPtr first_property_name, IntPtr var_args);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_child_notify (IntPtr raw, IntPtr child, IntPtr property_name);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_child_notify_by_pspec (IntPtr raw, IntPtr child, IntPtr pspec);

//		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
//		private static extern void gtk_container_forall (IntPtr raw, CallbackNative cb, IntPtr callback_data);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint gtk_container_get_border_width (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_border_width (IntPtr raw, uint border_width);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_propagate_draw (IntPtr raw, IntPtr child, IntPtr cairo_context);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_container_get_focus_chain (IntPtr raw, out IntPtr list_ptr);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_focus_chain (IntPtr raw, IntPtr list_ptr);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_unset_focus_chain (IntPtr raw);

		#endregion

		#region Properties
		/// <summary>
		/// The width of the empty border outside the containers children.
		/// </summary>
		/// <value>Allowed values: <= 65535. Default value: 0</value>
		[Property ("border-width")]
		public uint BorderWidth {
			get {
				return Container.gtk_container_get_border_width (base.Handle);
			}
			set {
				Container.gtk_container_set_border_width (base.Handle, value);
			}
		}
		/// <summary>
		/// Can be used to add a new child to the container.
		/// </summary>
		/// <value>The child.</value>
		[Property ("child")]
		public Widget Child {
			set {
				GLib.Value val = new GLib.Value (value.Handle);
				base.SetProperty ("child", val);
				val.Dispose ();
			}
		}

		/// <summary>
		/// Specify how resize events are handled.
		/// </summary>
		/// <value>Default value: ResizeMode.Parent .</value>
		[Property ("resize-mode")]
		public ResizeMode ResizeMode {
			get {
				Value property = base.GetProperty ("resize-mode");
				ResizeMode result = (ResizeMode)((Enum)property);
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("resize-mode", val);
				val.Dispose ();
			}
		}


		/// <summary>
		///  Obtains an array of the container's (non-internal) children.
		/// </summary>
		public Widget[] Children {
			get {
				IntPtr list_ptr = Container.gtk_container_get_children (base.Handle);
				return (Widget[])Marshaller.ListPtrToArray (list_ptr, typeof(List), true, false, typeof(Widget));
			}
		}

	
		/// <summary>
		///  Sets or obtains a focus chain of the container, overriding the one computed automatically by Gtk#.
		/// </summary>
		public Widget[] FocusChain {
			get {
				IntPtr raw;
				if (!Container.gtk_container_get_focus_chain (base.Handle, out raw)) {
					return new Widget[0];
				}
				List list = new List (raw);
				Widget[] array = new Widget[list.Count];
				for (int i = 0; i < list.Count; i++) {
					array [i] = (list [i] as Widget);
				}
				return array;
			}
			set {
				List list = new List (IntPtr.Zero);
				for (int i = 0; i < value.Length; i++) {
					Widget widget = value [i];
					list.Append (widget.Handle);
				}
				Container.gtk_container_set_focus_chain (base.Handle, list.Handle);
			}
		}

		/// <summary>
		/// Moves the focus to a particular child widget or finds the last-focused widget.
		/// </summary>
		public Widget FocusChild {
			get {
				IntPtr ptr=Container.gtk_container_get_focus_child(base.Handle);
				return GLib.Object.GetObject (ptr) as Widget; 
			}
			set {
				Container.gtk_container_set_focus_child (base.Handle, (value != null) ? value.Handle : IntPtr.Zero);
			}
		}

		/// <summary>
		/// The horizontal focus adjustment.
		/// </summary>
		public Adjustment FocusHadjustment {
			get {
				IntPtr o = Container.gtk_container_get_focus_hadjustment (base.Handle);
				return GLib.Object.GetObject (o) as Adjustment;
			}
			set {
				Container.gtk_container_set_focus_hadjustment (base.Handle, (value != null) ? value.Handle : IntPtr.Zero);
			}
		}

		/// <summary>
		/// The vertical focus adjustment.
		/// </summary>
		public Adjustment FocusVadjustment {
			get {
				IntPtr o = Container.gtk_container_get_focus_vadjustment (base.Handle);
				return GLib.Object.GetObject (o) as Adjustment;
			}
			set {
				Container.gtk_container_set_focus_vadjustment (base.Handle, (value != null) ? value.Handle : IntPtr.Zero);
			}
		}


		#endregion

		#region Events
		/// <summary>
		/// Raised when a child widget is added to the container via Container.Add.
		/// </summary>
		[Signal ("add")]
		public event AddedHandler Added {
			add {
				Signal signal = Signal.Lookup (this, "add", typeof(AddedArgs));
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "add", typeof(AddedArgs));
				signal.RemoveDelegate (value);
			}
		}
		/// <summary>
		/// Raised when the focus moves to a child widget of this container.
		/// </summary>
		[Signal ("set-focus-child")]
		public event FocusChildSetHandler FocusChildSet {
			add {
				Signal signal = Signal.Lookup (this, "set-focus-child", typeof(FocusChildSetArgs));
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "set-focus-child", typeof(FocusChildSetArgs));
				signal.RemoveDelegate (value);
			}
		}

		/// <summary>
		/// Raised when a child widget is removed from this container.
		/// </summary>
		[Signal ("remove")]
		public event RemovedHandler Removed {
			add {
				Signal signal = Signal.Lookup (this, "remove", typeof(RemovedArgs));
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "remove", typeof(RemovedArgs));
				signal.RemoveDelegate (value);
			}
		}

		/// <summary>
		/// Raised when this container's resizability is queried.
		/// </summary>
		[Signal ("check-resize")]
		public event EventHandler ResizeChecked {
			add {
				Signal signal = Signal.Lookup (this, "check-resize");
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "check-resize");
				signal.RemoveDelegate (value);
			}
		}


		#endregion

		#region Methods

		/// <summary>
		/// Returns an IEnumerator for the container's children
		/// </summary>
		/// <returns>The enumerator.</returns>
		public IEnumerator GetEnumerator ()
		{
			return this.Children.GetEnumerator ();
		}

		/// <summary>
		/// Adds a Gtk3.Widget to the Gtk3.Container.
		/// </summary>
		/// <param name="widget">Widget.</param>
		public void Add (Widget widget)
		{
			Container.gtk_container_add (base.Handle, (widget != null) ? widget.Handle : IntPtr.Zero);
		}

		/// <summary>
		/// Attempts to resize this container.
		/// </summary>
		public void CheckResize ()
		{
			Container.gtk_container_check_resize (base.Handle);
		}

		public GLib.List GetChildren()
		{
			IntPtr o = Container.gtk_container_get_children (base.Handle);
			return new GLib.List(o);
		}

		/// <summary>
		/// Removes a Widget from the Container.
		/// </summary>
		/// <param name="widget">Widget.</param>
		public void Remove (Widget widget)
		{
			Container.gtk_container_remove (base.Handle, (widget != null) ? widget.Handle : IntPtr.Zero);
		}


		/// <summary>
		/// Removes a focus chain.
		/// </summary>
		public void UnsetFocusChain ()
		{
			Container.gtk_container_unset_focus_chain (base.Handle);
		}

		/// <summary>
		/// Gets a child property of a Gtk3.Widget.
		/// </summary>A child of this Gtk3.Container.</param>
		/// <param name="propertyName">The child property name.</param>
		public GLib.Value ChildGetProperty (Widget child, string propertyName)
		{
			GLib.Value result = default(Value);
			IntPtr intPtr = Marshaller.StringToPtrGStrdup (propertyName);
			Container.gtk_container_child_get_property (base.Handle, child.Handle, intPtr, out result);
			Marshaller.Free (intPtr);
			return result;
		}

		/// <summary>
		/// Sets a child property of a Gtk3.Widget.
		/// </summary>
		/// <param name="child">A child of this Gtk3.Container.</param>
		/// <param name="propertyName">The child property name</param>
		/// <param name="value">The value to set property_name to.</param>
		public void ChildSetProperty (Widget child, string propertyName,GLib.Value value)
		{
			IntPtr intPtr = Marshaller.StringToPtrGStrdup (propertyName);
			Container.gtk_container_child_set_property (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, intPtr, ref value);
			Marshaller.Free (intPtr);
		}

		public void ChildGetValist (Widget child, string first_property_name, IntPtr var_args)
		{
			IntPtr intPtr = Marshaller.StringToPtrGStrdup (first_property_name);
			Container.gtk_container_child_get_valist (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, intPtr, out var_args);
			Marshaller.Free (intPtr);
		}

		public void ChildSetValist (Widget child, string first_property_name, IntPtr var_args)
		{
			IntPtr intPtr = Marshaller.StringToPtrGStrdup (first_property_name);
			Container.gtk_container_child_set_valist (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, intPtr, var_args);
			Marshaller.Free (intPtr);
		}

		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor.
		/// </summary>
		protected Container () : base (IntPtr.Zero)
		{
			
		}
		/// <summary>
		///Internal constructor.Constructs the object from a C-based pointer.
		/// </summary>
		/// <param name="raw">The raw GObject reference associated with this object.</param>
		public Container (IntPtr raw) : base (raw)
		{
		}

		#endregion

	}

}