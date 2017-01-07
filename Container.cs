using Gdk;
using GLib;
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Gtk3
{
	public class Container : Widget, IEnumerable
	{

		#region Delegats 

		[CDeclCallback]
		private delegate void AddedVMDelegate (IntPtr container, IntPtr widget);

		[CDeclCallback]
		private delegate IntPtr ChildTypeDelegate (IntPtr raw);

		[CDeclCallback]
		private delegate void FocusChildSetVMDelegate (IntPtr container, IntPtr widget);

		[CDeclCallback]
		private delegate void ForallDelegate (IntPtr container, bool include_internals, IntPtr cb, IntPtr data);

		[CDeclCallback]
		private delegate void RemovedVMDelegate (IntPtr container, IntPtr widget);

		[CDeclCallback]
		private delegate void ResizeCheckedVMDelegate (IntPtr container);

		//Static Fields

		private static Container.ResizeCheckedVMDelegate ResizeCheckedVMCallback;

		private static Container.RemovedVMDelegate RemovedVMCallback;

		private static Container.ChildTypeDelegate ChildTypeCallback;

		private static Container.ForallDelegate ForallCallback;

		private static Container.FocusChildSetVMDelegate FocusChildSetVMCallback;

		private static Container.AddedVMDelegate AddedVMCallback;

		#endregion

		#region Gtk+ native functions

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_add (IntPtr raw, IntPtr widget);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_check_resize (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_child_get_valist (IntPtr raw, IntPtr child, IntPtr first_property_name, IntPtr var_args);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_child_set_property (IntPtr raw, IntPtr child, IntPtr property_name, IntPtr value);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_child_set_valist (IntPtr raw, IntPtr child, IntPtr first_property_name, IntPtr var_args);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_child_type (IntPtr raw);

//		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
//		private static extern void gtk_container_forall (IntPtr raw, CallbackNative cb, IntPtr callback_data);
//
//		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
//		private static extern void gtk_container_foreach (IntPtr raw, CallbackNative cb, IntPtr callback_data);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint gtk_container_get_border_width (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_get_children (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_container_get_focus_chain (IntPtr raw, out IntPtr list_ptr);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_get_focus_child (IntPtr Raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_get_focus_hadjustment (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_get_focus_vadjustment (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_container_get_resize_mode (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_container_get_type ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_propagate_expose (IntPtr raw, IntPtr child, IntPtr evnt);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_remove (IntPtr raw, IntPtr widget);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_resize_children (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_border_width (IntPtr raw, uint border_width);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_focus_chain (IntPtr raw, IntPtr list_ptr);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_focus_child (IntPtr raw, IntPtr child);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_focus_hadjustment (IntPtr raw, IntPtr adjustment);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_focus_vadjustment (IntPtr raw, IntPtr adjustment);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_reallocate_redraws (IntPtr raw, bool needs_redraws);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_set_resize_mode (IntPtr raw, int resize_mode);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_container_unset_focus_chain (IntPtr raw);

		#endregion

		#region Native container's properties

		[Property ("border-width")]
		public uint BorderWidth {
			get {
				return Container.gtk_container_get_border_width (base.Handle);
			}
			set {
				Container.gtk_container_set_border_width (base.Handle, value);
			}
		}

		[Property ("child")]
		public Widget Child {
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("child", val);
				val.Dispose ();
			}
		}


		[Property ("resize-mode")]
		public ResizeMode ResizeMode {
			get {
				return (ResizeMode)Container.gtk_container_get_resize_mode (base.Handle);
			}
			set {
				Container.gtk_container_set_resize_mode (base.Handle, (int)value);
			}
		}


		#endregion

		#region Sharp container's properties

		public Widget[] Children {
			get {
				IntPtr list_ptr = Container.gtk_container_get_children (base.Handle);
				return (Widget[])Marshaller.ListPtrToArray (list_ptr, typeof(List), true, false, typeof(Widget));
			}
		}

		public new static GType GType {
			get {
				IntPtr val = Container.gtk_container_get_type ();
				GType result = new GType (val);
				return result;
			}
		}

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

		public Widget FocusChild {
			get {
				IntPtr ptr=Container.gtk_container_get_focus_child(base.Handle);
				return GLib.Object.GetObject (ptr) as Widget; 
			}
			set {
				Container.gtk_container_set_focus_child (base.Handle, (value != null) ? value.Handle : IntPtr.Zero);
			}
		}




		#endregion

		#region Native container's signals

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

		public IEnumerator GetEnumerator ()
		{
			return this.Children.GetEnumerator ();
		}

		#endregion

		#region Constructors
		//
		// Constructors
		//
		protected Container () : base (IntPtr.Zero)
		{
			this.CreateNativeObject (new string[0], new Value[0]);
		}

		public Container (IntPtr raw) : base (raw)
		{
		}

		#endregion

	}

}