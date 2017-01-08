using System;
using System.Runtime.InteropServices;
using GLib;
using Gdk;

namespace Gtk3{

	public partial class Window:Widget{

		#region import native functions

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_activate_default (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_activate_focus (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_activate_key (IntPtr raw, IntPtr evnt);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_add_accel_group (IntPtr raw, IntPtr accel_group);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_add_embedded_xid (IntPtr raw, uint xid);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_add_mnemonic (IntPtr raw, uint keyval, IntPtr target);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_begin_move_drag (IntPtr raw, int button, int root_x, int root_y, uint timestamp);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_begin_resize_drag (IntPtr raw, int edge, int button, int root_x, int root_y, uint timestamp);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_deiconify (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_fullscreen (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_get_accept_focus (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_get_decorated (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_default_icon_list ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_get_default_size (IntPtr raw, out int width, out int height);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_get_deletable (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_get_destroy_with_parent (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_focus (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_get_focus_on_map (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_get_frame_dimensions (IntPtr raw, out int left, out int top, out int right, out int bottom);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_window_get_gravity (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_group (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_get_has_frame (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_icon (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_icon_list (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_icon_name (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_window_get_mnemonic_modifier (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_get_modal (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double gtk_window_get_opacity (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_get_position (IntPtr raw, out int root_x, out int root_y);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_get_resizable (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_role (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_screen (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_get_size (IntPtr raw, out int width, out int height);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_get_skip_pager_hint (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_get_skip_taskbar_hint (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_transient_for (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_type ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_window_get_type_hint (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_get_urgency_hint (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_iconify (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_list_toplevels ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_maximize (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_mnemonic_activate (IntPtr raw, uint keyval, int modifier);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_move (IntPtr raw, int x, int y);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_parse_geometry (IntPtr raw, IntPtr geometry);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_present (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_present_with_time (IntPtr raw, uint timestamp);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_propagate_key_event (IntPtr raw, IntPtr evnt);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_remove_accel_group (IntPtr raw, IntPtr accel_group);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_remove_embedded_xid (IntPtr raw, uint xid);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_remove_mnemonic (IntPtr raw, uint keyval, IntPtr target);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_reshow_with_initial_size (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_resize (IntPtr raw, int width, int height);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_accept_focus (IntPtr raw, bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_auto_startup_notification (bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_decorated (IntPtr raw, bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_default (IntPtr raw, IntPtr default_widget);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_default_icon (IntPtr icon);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_set_default_icon_from_file (IntPtr filename, out IntPtr err);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_set_default_icon_from_file_utf8 (IntPtr filename, out IntPtr err);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_default_icon_list (IntPtr list);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_default_icon_name (IntPtr name);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_default_size (IntPtr raw, int width, int height);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_deletable (IntPtr raw, bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_destroy_with_parent (IntPtr raw, bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_focus (IntPtr raw, IntPtr focus);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_focus_on_map (IntPtr raw, bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_frame_dimensions (IntPtr raw, int left, int top, int right, int bottom);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_geometry_hints (IntPtr raw, IntPtr geometry_widget, IntPtr geometry, int geom_mask);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_gravity (IntPtr raw, int gravity);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_has_frame (IntPtr raw, bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_icon (IntPtr raw, IntPtr icon);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_set_icon_from_file (IntPtr raw, IntPtr filename, out IntPtr err);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_window_set_icon_from_file_utf8 (IntPtr raw, IntPtr filename, out IntPtr err);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_icon_list (IntPtr raw, IntPtr list);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_icon_name (IntPtr raw, IntPtr name);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_keep_above (IntPtr raw, bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_keep_below (IntPtr raw, bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_mnemonic_modifier (IntPtr raw, int modifier);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_modal (IntPtr raw, bool modal);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_opacity (IntPtr raw, double opacity);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_policy (IntPtr raw, int allow_shrink, int allow_grow, int auto_shrink);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_position (IntPtr raw, int position);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_resizable (IntPtr raw, bool resizable);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_role (IntPtr raw, IntPtr role);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_screen (IntPtr raw, IntPtr screen);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_skip_pager_hint (IntPtr raw, bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_skip_taskbar_hint (IntPtr raw, bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_startup_id (IntPtr raw, IntPtr startup_id);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_transient_for (IntPtr raw, IntPtr parent);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_type_hint (IntPtr raw, int hint);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_urgency_hint (IntPtr raw, bool setting);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_wmclass (IntPtr raw, IntPtr wmclass_name, IntPtr wmclass_class);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_stick (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_unfullscreen (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_unmaximize (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_unstick (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_new (int type);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_title (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_title (IntPtr raw, IntPtr title);

		#endregion

		#region Gtk+3 native functions

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_window_get_attached_to (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_window_set_attached_to (IntPtr raw, IntPtr widget);

		#endregion



		#region Native window properties

		[Property ("accept-focus")]
		//Whether the window should receive the input focus.
		public bool AcceptFocus {
			get {
				return Gtk3.Window.gtk_window_get_accept_focus (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_accept_focus (base.Handle, value);
			}
		}

		[Property ("attached-to")]
		//The widget to which this window is attached. 
		public Widget AttachedTo {
			get {
				IntPtr ptr = Gtk3.Window.gtk_window_get_attached_to (base.Handle);
				return GLib.Object.GetObject (ptr) as Widget; 
			}

			set {
				Gtk3.Window.gtk_window_set_attached_to(base.Handle, (value != null) ? value.Handle : IntPtr.Zero);
			}

		}

		[Property ("decorated")]
		//Whether the window should be decorated by the window manager.
		public bool Decorated {
			get {
				return Gtk3.Window.gtk_window_get_decorated (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_decorated (base.Handle, value);
			}
		}

		[Property ("default-height")]
		//The default height of the window, used when initially showing the window.
		public int DefaultHeight {
			get {
				GLib.Value property = base.GetProperty ("default-height");
				int result = (int)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("default-height", val);
				val.Dispose ();
			}
		}

		[Property ("default-width")]
		//The default widht of the window, used when initially showing the window.
		public int DefaultWidth {
			get {
				GLib.Value property = base.GetProperty ("default-width");
				int result = (int)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("default-width", val);
				val.Dispose ();
			}
		}

		[Property ("deletable")]
		//Whether the window frame should have a close button.
		public bool Deletable {
			get {
				return Gtk3.Window.gtk_window_get_deletable (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_deletable (base.Handle, value);
			}
		}

		[Property ("destroy-with-parent")]
		//If this window should be destroyed when the parent is destroyed.
		public bool DestroyWithParent {
			get {
				return Gtk3.Window.gtk_window_get_destroy_with_parent (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_destroy_with_parent (base.Handle, value);
			}
		}

		[Property ("focus-on-map")]
		//Whether the window should receive the input focus when mapped.
		public bool FocusOnMap {
			get {
				return Gtk3.Window.gtk_window_get_focus_on_map (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_focus_on_map (base.Handle, value);
			}
		}

		[Property ("gravity")]
		//The window gravity of the window. 
		public Gdk.Gravity Gravity {
			get {
				return (Gdk.Gravity)Gtk3.Window.gtk_window_get_gravity (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_gravity (base.Handle, (int)value);
			}
		}

		[Property ("has-toplevel-focus")]
		//Whether the input focus is within this Gtk3.Window.
		public bool HasToplevelFocus {
			get {
				Value property = base.GetProperty ("has-toplevel-focus");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
		}

		[Property ("hide-titlebar-when-maximized")]
		//Whether the titlebar should be hidden during maximization.
		public bool HideTitlebarWhenMaximized {
			get {
				GLib.Value property = base.GetProperty ("hide-titlebar-when-maximized");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("hide-titlebar-when-maximized", val);
				val.Dispose ();
			}
		}

		[Property ("icon")]
		//Icon for this window.
		public Pixbuf Icon {
			get {
				IntPtr o = Gtk3.Window.gtk_window_get_icon (base.Handle);
				return GLib.Object.GetObject (o) as Pixbuf;
			}
			set {
				Gtk3.Window.gtk_window_set_icon (base.Handle, (value != null) ? value.Handle : IntPtr.Zero);
			}
		}

	
		[Property ("icon-name")]
		public string IconName {
			get {
				IntPtr ptr = Gtk3.Window.gtk_window_get_icon_name (base.Handle);
				return Marshaller.Utf8PtrToString (ptr);
			}
			set {
				IntPtr intPtr = Marshaller.StringToPtrGStrdup (value);
				Gtk3.Window.gtk_window_set_icon_name (base.Handle, intPtr);
				Marshaller.Free (intPtr);
			}
		}

		[Property ("is-active")]
		//Whether the toplevel is the current active window.
		public bool IsActive {
			get {
				Value property = base.GetProperty ("is-active");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
		}

		[Property ("is-maximized")]
		//Whether the window is maximized.
		public bool IsMaximized {
			get {
				Value property = base.GetProperty ("is-maximized");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
		}


		[Property ("modal")]
		//If TRUE, the window is modal (other windows are not usable while this one is up).
		public bool Modal {
			get {
				return Gtk3.Window.gtk_window_get_modal (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_modal (base.Handle, value);
			}
		}

		[Property ("resizable")]
		//If TRUE, users can resize the window.
		public bool Resizable {
			get {
				return Gtk3.Window.gtk_window_get_resizable (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_resizable (base.Handle, value);
			}
		}

		[Property ("role")]
		//Unique identifier for the window to be used when restoring a session
		public string Role {
			get {
				GLib.Value property = base.GetProperty ("role");
				string result = (string)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("role", val);
				val.Dispose ();
			}
		}

		[Property ("screen")]
		//The screen where this window will be displayed.
		public Gdk.Screen Screen {
			get {
				IntPtr o = Gtk3.Window.gtk_window_get_screen (base.Handle);
				return GLib.Object.GetObject (o) as Gdk.Screen;
			}
			set {
				Gtk3.Window.gtk_window_set_screen (base.Handle, (value != null) ? value.Handle : IntPtr.Zero);
			}
		}

		[Property ("skip-pager-hint")]
		//TRUE if the window should not be in the pager.
		public bool SkipPagerHint {
			get {
				return Gtk3.Window.gtk_window_get_skip_pager_hint (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_skip_pager_hint (base.Handle, value);
			}
		}

		[Property ("skip-taskbar-hint")]
		//TRUE if the window should not be in the task bar.
		public bool SkipTaskbarHint {
			get {
				return Gtk3.Window.gtk_window_get_skip_taskbar_hint (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_skip_taskbar_hint (base.Handle, value);
			}
		}


		[Property ("startup-id")]
		//Window's startup notification identifier.
		public string StartupId {
			set {
				IntPtr intPtr = Marshaller.StringToPtrGStrdup (value);
				Gtk3.Window.gtk_window_set_startup_id (base.Handle, intPtr);
				Marshaller.Free (intPtr);
			}
		}

		[Property ("title")]
		//The title of the window.
		public string Title {
			get {
				IntPtr ptr = Gtk3.Window.gtk_window_get_title (base.Handle);
				return Marshaller.Utf8PtrToString (ptr);
			}
			set {
				IntPtr intPtr = Marshaller.StringToPtrGStrdup (value);
				Gtk3.Window.gtk_window_set_title (base.Handle, intPtr);
				Marshaller.Free (intPtr);
			}
		}

		[Property ("transient-for")]
		//The transient parent of the window.
		public Window TransientFor {
			get {
				IntPtr o = Gtk3.Window.gtk_window_get_transient_for (base.Handle);
				return GLib.Object.GetObject (o) as Window;
			}
			set {
				Gtk3.Window.gtk_window_set_transient_for (base.Handle, (value != null) ? value.Handle : IntPtr.Zero);
			}
		}

		 
		[Property ("type")]
		//The type of the window.
		public WindowType Type {
			get {
				Value property = base.GetProperty ("type");
				WindowType result = (WindowType)((Enum)property);
				property.Dispose ();
				return result;
			}
		}

		[Property ("type-hint")]
		//Hint to help the desktop environment understand what kind of window this is and how to treat it.
		public WindowTypeHint TypeHint {
			get {
				return (WindowTypeHint)Gtk3.Window.gtk_window_get_type_hint (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_type_hint (base.Handle, (int)value);
			}
		}

		[Property ("urgency-hint")]
		//TRUE if the window should be brought to the user's attention.
		public bool UrgencyHint {
			get {
				return Gtk3.Window.gtk_window_get_urgency_hint (base.Handle);
			}
			set {
				Gtk3.Window.gtk_window_set_urgency_hint (base.Handle, value);
			}
		}

		[Property ("window-position")]
		//The initial position of the window.
		public WindowPosition WindowPosition {
			get {
				Value property = base.GetProperty ("window-position");
				WindowPosition result = (WindowPosition)((Enum)property);
				property.Dispose ();
				return result;
			}
			set {
				Value val = new Value (value);
				base.SetProperty ("window-position", val);
				val.Dispose ();
			}
		}

		#endregion

		public Window (WindowType type)
		{
			this.Raw = Gtk3.Window.gtk_window_new ((int)type);
		}

		public Window (IntPtr raw) : base (raw)
		{
			this.Raw = raw;
		}

	}



}
