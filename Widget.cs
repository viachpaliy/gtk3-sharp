using Atk;
using Gdk;
using GLib;
using Pango;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Gtk3{

	[TypeInitializer (typeof(Widget), "ClassInit")]
	public class Widget:GLib.InitiallyUnowned, Implementor, IWrapper{
					
			
		#region Gtk+2 native  functions

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_activate (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_add_accelerator (IntPtr raw, IntPtr accel_signal, IntPtr accel_group, uint accel_key, int accel_mods, int accel_flags);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_add_events (IntPtr raw, int events);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_add_mnemonic_label (IntPtr raw, IntPtr label);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_can_activate_accel (IntPtr raw, uint signal_id);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_child_focus (IntPtr raw, int direction);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_child_notify (IntPtr raw, IntPtr child_property);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_class_path (IntPtr raw, out uint path_length, out IntPtr path, out IntPtr path_reversed);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_create_pango_context (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_create_pango_layout (IntPtr raw, IntPtr text);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_draw (IntPtr raw, IntPtr area);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_ensure_style (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_error_bell (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_event (IntPtr raw, IntPtr evnt);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_freeze_child_notify (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_accessible (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_action (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_ancestor (IntPtr raw, IntPtr widget_type);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_get_child_requisition (IntPtr raw, IntPtr requisition);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_get_child_visible (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_clipboard (IntPtr raw, IntPtr selection);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_colormap (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_composite_name (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_default_colormap ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_get_default_direction ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_default_style ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_default_visual ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_get_direction (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_display (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_get_events (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_get_extension_events (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_get_has_tooltip (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_modifier_style (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_name (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_get_no_show_all (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_pango_context (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_parent (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_parent_window (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_get_pointer (IntPtr raw, out int x, out int y);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_root_window (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_screen (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_settings (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_get_size_request (IntPtr raw, out int width, out int height);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_style (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_tooltip_markup (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_tooltip_text (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_tooltip_window (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_toplevel (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_type ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_visual (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_grab_default (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_grab_focus (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_has_screen (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_hide (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_hide_all (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_hide_on_delete (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_input_shape_combine_mask (IntPtr raw, IntPtr shape_mask, int offset_x, int offset_y);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_intersect (IntPtr raw, IntPtr area, IntPtr intersection);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_is_ancestor (IntPtr raw, IntPtr ancestor);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_is_composited (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_is_focus (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_keynav_failed (IntPtr raw, int direction);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_list_mnemonic_labels (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_map (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_mnemonic_activate (IntPtr raw, bool group_cycling);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_modify_base (IntPtr raw, int state, IntPtr color);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_modify_bg (IntPtr raw, int state, IntPtr color);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_modify_cursor (IntPtr raw, IntPtr primary, IntPtr secondary);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_modify_fg (IntPtr raw, int state, IntPtr color);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_modify_font (IntPtr raw, IntPtr font_desc);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_modify_style (IntPtr raw, IntPtr style);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_modify_text (IntPtr raw, int state, IntPtr color);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_path (IntPtr raw, out uint path_length, out IntPtr path, out IntPtr path_reversed);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_pop_colormap ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_pop_composite_child ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_push_colormap (IntPtr cmap);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_push_composite_child ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_queue_clear (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_queue_clear_area (IntPtr raw, int x, int y, int width, int height);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_queue_draw (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_queue_draw_area (IntPtr raw, int x, int y, int width, int height);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_queue_resize (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_queue_resize_no_redraw (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_realize (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_region_intersect (IntPtr raw, IntPtr region);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_remove_accelerator (IntPtr raw, IntPtr accel_group, uint accel_key, int accel_mods);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_remove_mnemonic_label (IntPtr raw, IntPtr label);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_render_icon (IntPtr raw, IntPtr stock_id, int size, IntPtr detail);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_reparent (IntPtr raw, IntPtr new_parent);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_reset_rc_styles (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_reset_shapes (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_send_expose (IntPtr raw, IntPtr evnt);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_accel_path (IntPtr raw, IntPtr accel_path, IntPtr accel_group);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_app_paintable (IntPtr raw, bool app_paintable);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_child_visible (IntPtr raw, bool is_visible);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_colormap (IntPtr raw, IntPtr colormap);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_composite_name (IntPtr raw, IntPtr name);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_default_colormap (IntPtr colormap);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_default_direction (int dir);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_direction (IntPtr raw, int dir);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_double_buffered (IntPtr raw, bool double_buffered);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_events (IntPtr raw, int events);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_extension_events (IntPtr raw, int mode);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_has_tooltip (IntPtr raw, bool has_tooltip);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_name (IntPtr raw, IntPtr name);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_no_show_all (IntPtr raw, bool no_show_all);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_parent (IntPtr raw, IntPtr parent);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_parent_window (IntPtr raw, IntPtr parent_window);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_redraw_on_allocate (IntPtr raw, bool redraw_on_allocate);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_set_scroll_adjustments (IntPtr raw, IntPtr hadjustment, IntPtr vadjustment);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_sensitive (IntPtr raw, bool sensitive);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_size_request (IntPtr raw, int width, int height);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_state (IntPtr raw, int state);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_style (IntPtr raw, IntPtr style);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_tooltip_markup (IntPtr raw, IntPtr markup);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_tooltip_text (IntPtr raw, IntPtr text);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_tooltip_window (IntPtr raw, IntPtr custom_window);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_uposition (IntPtr raw, int x, int y);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_usize (IntPtr raw, int width, int height);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_shape_combine_mask (IntPtr raw, IntPtr shape_mask, int offset_x, int offset_y);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_show (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_show_all (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_show_now (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_size_allocate (IntPtr raw, IntPtr allocation);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_size_request (IntPtr raw, IntPtr requisition);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_thaw_child_notify (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_translate_coordinates (IntPtr raw, IntPtr dest_widget, int src_x, int src_y, out int dest_x, out int dest_y);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_trigger_tooltip_query (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_unmap (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_unparent (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_unrealize (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_window (IntPtr raw);

		[DllImport (Global.AtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr atk_implementor_ref_accessible (IntPtr raw);

		#endregion

		#region Gtk+3 native functions

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_get_halign (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_halign (IntPtr raw, int align); 

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_get_valign (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_valign (IntPtr raw, int align); 

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_get_hexpand (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_hexpand (IntPtr raw, bool expand);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_get_hexpand_set  (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_hexpand_set (IntPtr raw, bool set);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_get_vexpand (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_vexpand (IntPtr raw, bool expand);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_widget_get_vexpand_set  (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_vexpand_set (IntPtr raw, bool set);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_get_margin_bottom (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_margin_bottom (IntPtr raw, int margin);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_get_margin_end (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_margin_end (IntPtr raw, int margin);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_get_margin_start (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_margin_start (IntPtr raw, int margin);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_get_margin_top (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_margin_top (IntPtr raw, int margin);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double gtk_widget_get_opacity (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_set_opacity (IntPtr raw, double opacity);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_widget_get_scale_factor (IntPtr raw);


		#endregion



		#region Native widget's properties

		[Property ("app-paintable")]
		//Whether the application will paint directly on the widget.
		public bool AppPaintable {
			get {
				GLib.Value property = base.GetProperty ("app-paintable");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
			set {
				Widget.gtk_widget_set_app_paintable (base.Handle, value);
			}
		}

		[Property ("can-default")]
		//Whether the widget can be the default widget.
		public bool CanDefault {
			get {
				GLib.Value property = base.GetProperty ("can-default");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("can-default", val);
				val.Dispose ();
			}
		}

		[Property ("can-focus")]
		//Whether the widget can accept the input focus.
		public bool CanFocus {
			get {
				GLib.Value property = base.GetProperty ("can-focus");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("can-focus", val);
				val.Dispose ();
			}
		}

		[Property ("composite-child")]
		//Whether the widget is part of a composite widget.
		public bool CompositeChild {
			get {
				GLib.Value property = base.GetProperty ("composite-child");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
		}

		[Property ("events")]
		//The event mask that decides what kind of GdkEvents this widget gets.
		public EventMask Events {
			get {
				return (EventMask)Widget.gtk_widget_get_events (base.Handle);
			}
			set {
				Widget.gtk_widget_set_events (base.Handle, (int)value);
			}
		}

		[Property ("expand")]
		//Whether to expand in both directions. Setting this sets both “hexpand” and “vexpand”
		public bool Expand {
			get {
				GLib.Value property = base.GetProperty ("expand");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("expand", val);
				val.Dispose ();
			}
		}

		[Property ("focus-on-click")]
		//Whether the widget should grab focus when it is clicked with the mouse.
		public bool FocusOnClick {
			get {
				GLib.Value property = base.GetProperty ("focus-on-click");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("focus-on-click", val);
				val.Dispose ();
			}
		}

		[Property ("halign")]
		//How to distribute horizontal space if widget gets extra space, see GtkAlign
		public GtkAlign Halign {
			get {
				return (GtkAlign)Widget.gtk_widget_get_halign (base.Handle);
			}
			set {
				Widget.gtk_widget_set_halign (base.Handle, (int)value);
			}
		}


		[Property ("has-default")]
		//Whether the widget is the default widget.
		public bool HasDefault {
			get {
				GLib.Value property = base.GetProperty ("has-default");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("has-default", val);
				val.Dispose ();
			}
		}


		[Property ("has-focus")]
		//Whether the widget has the input focus.
		public bool HasFocus {
			get {
				GLib.Value property = base.GetProperty ("has-focus");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("has-focus", val);
				val.Dispose ();
			}
		}

		[Property ("has-tooltip")]
		//Enables or disables the emission of “query-tooltip” on widget .
		public bool HasTooltip {
			get {
				return Widget.gtk_widget_get_has_tooltip (base.Handle);
			}
			set {
				Widget.gtk_widget_set_has_tooltip (base.Handle, value);
			}
		}


		[Property ("height-request")]
		//Override for height request of the widget, or -1 if natural request should be used.
		public int HeightRequest {
			get {
				GLib.Value property = base.GetProperty ("height-request");
				int result = (int)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("height-request", val);
				val.Dispose ();
			}
		}

		[Property ("hexpand")]
		//Whether to expand horizontally. 
		public bool Hexpand {
			get {
				return Widget.gtk_widget_get_hexpand(base.Handle);
			}
			set {
				Widget.gtk_widget_set_hexpand (base.Handle, value);
			}
		}

		[Property ("hexpand-set")]
		//Whether to use the “hexpand” property.
		public bool HexpandSet {
			get {
				return Widget.gtk_widget_get_hexpand_set(base.Handle);
			}
			set {
				Widget.gtk_widget_set_hexpand_set (base.Handle, value);
			}
		}


		[Property ("is-focus")]
		//Whether the widget is the focus widget within the toplevel.
		public bool IsFocus {
			get {
				return Widget.gtk_widget_is_focus (base.Handle);
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("is-focus", val);
				val.Dispose ();
			}
		}

		[Property ("margin")]
		//Sets all four sides' margin at once. If read, returns max margin on any side.
		public int Margin {
			get {
				GLib.Value property = base.GetProperty ("margin");
				int result = (int)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("margin", val);
				val.Dispose ();
			}
		}

		[Property ("margin-bottom")]
		//Margin on bottom side of widget.
		public int MarginBottom {
			get {
				return Widget.gtk_widget_get_margin_bottom(base.Handle);
			}
			set {
				Widget.gtk_widget_set_margin_bottom (base.Handle, value);
			}
		}

		[Property ("margin-end")]
		//Margin on end of widget, horizontally. 
		public int MarginEnd {
			get {
				return Widget.gtk_widget_get_margin_end(base.Handle);
			}
			set {
				Widget.gtk_widget_set_margin_end (base.Handle, value);
			}
		}

		[Property ("margin-start")]
		//Margin on start of widget, horizontally.  
		public int MarginStart {
			get {
				return Widget.gtk_widget_get_margin_start(base.Handle);
			}
			set {
				Widget.gtk_widget_set_margin_start (base.Handle, value);
			}
		}

		[Property ("margin-top")]
		//Margin on top side of widget.
		public int MarginTop {
			get {
				return Widget.gtk_widget_get_margin_top(base.Handle);
			}
			set {
				Widget.gtk_widget_set_margin_top (base.Handle, value);
			}
		}

		[Property ("name")]
		//The name of the widget.
		public string Name {
			get {
				IntPtr ptr = Widget.gtk_widget_get_name (base.Handle);
				return Marshaller.Utf8PtrToString (ptr);
			}
			set {
				IntPtr intPtr = Marshaller.StringToPtrGStrdup (value);
				Widget.gtk_widget_set_name (base.Handle, intPtr);
				Marshaller.Free (intPtr);
			}
		}


		[Property ("no-show-all")]
		//Whether gtk_widget_show_all() should not affect this widget.
		public bool NoShowAll {
			get {
				return Widget.gtk_widget_get_no_show_all (base.Handle);
			}
			set {
				Widget.gtk_widget_set_no_show_all (base.Handle, value);
			}
		}

		[Property ("opacity")]
		//The requested opacity of the widget. 
		public double Opacity {
			get{
				return Widget.gtk_widget_get_opacity (base.Handle);
			}
			set {
				Widget.gtk_widget_set_opacity (base.Handle, value);
			}
		}


		[Property ("parent")]
		//The parent widget of this widget. Must be a Container widget.
		public Container Parent {
			get {
				IntPtr o = Widget.gtk_widget_get_parent (base.Handle);
				return GLib.Object.GetObject(o) as Container;
			}
			set {
				Widget.gtk_widget_set_parent (base.Handle, (value != null) ? value.Handle : IntPtr.Zero);
			}
		}


		[Property ("receives-default")]
		//If TRUE, the widget will receive the default action when it is focused.
		public bool ReceivesDefault {
			get {
				GLib.Value property = base.GetProperty ("receives-default");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("receives-default", val);
				val.Dispose ();
			}
		}

		[Property ("scale-factor")]
		//Retrieves the internal scale factor that maps from window coordinates to the actual device pixels.
		//On traditional systems this is 1, on high density outputs, it can be a higher value (typically 2).
		public int ScaleFactor {
			get{
				return Widget.gtk_widget_get_scale_factor (base.Handle);
			}
		}

		[Property ("sensitive")]
		//Whether the widget responds to input.
		public bool Sensitive {
			get {
				GLib.Value property = base.GetProperty ("sensitive");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
			set {
				Widget.gtk_widget_set_sensitive (base.Handle, value);
			}
		}

		[Property ("tooltip-markup")]
		//Sets the text of tooltip to be the given string, which is marked up with the Pango text markup language.
		public string TooltipMarkup {
			get {
				IntPtr ptr = Widget.gtk_widget_get_tooltip_markup (base.Handle);
				return Marshaller.PtrToStringGFree (ptr);
			}
			set {
				IntPtr intPtr = Marshaller.StringToPtrGStrdup (value);
				Widget.gtk_widget_set_tooltip_markup (base.Handle, intPtr);
				Marshaller.Free (intPtr);
			}
		}

		[Property ("tooltip-text")]
		//Sets the text of tooltip to be the given string.
		public string TooltipText {
			get {
				IntPtr ptr = Widget.gtk_widget_get_tooltip_text (base.Handle);
				return Marshaller.PtrToStringGFree (ptr);
			}
			set {
				IntPtr intPtr = Marshaller.StringToPtrGStrdup (value);
				Widget.gtk_widget_set_tooltip_text (base.Handle, intPtr);
				Marshaller.Free (intPtr);
			}
		}


		[Property ("valign")]
		//How to distribute vertical space if widget gets extra space.
		public GtkAlign Valign {
			get {
				return (GtkAlign)Widget.gtk_widget_get_valign (base.Handle);
			}
			set {
				Widget.gtk_widget_set_valign (base.Handle, (int)value);
			}
		}

		[Property ("vexpand")]
		//Whether to expand vertically.
		public bool Vexpand {
			get {
				return Widget.gtk_widget_get_vexpand(base.Handle);
			}
			set {
				Widget.gtk_widget_set_vexpand (base.Handle, value);
			}
		}

		[Property ("vexpand-set")]
		//Whether to use the “vexpand” property.
		public bool VexpandSet {
			get {
				return Widget.gtk_widget_get_vexpand_set(base.Handle);
			}
			set {
				Widget.gtk_widget_set_vexpand_set (base.Handle, value);
			}
		}

		[Property ("visible")]
		//Whether the widget is visible.
		public bool Visible {
			get {
				GLib.Value property = base.GetProperty ("visible");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("visible", val);
				val.Dispose ();
			}
		}

		[Property ("width-request")]
		//Override for width request of the widget, or -1 if natural request should be used.
		public int WidthRequest {
			get {
				GLib.Value property = base.GetProperty ("width-request");
				int result = (int)property;
				property.Dispose ();
				return result;
			}
			set {
				GLib.Value val = new GLib.Value (value);
				base.SetProperty ("width-request", val);
				val.Dispose ();
			}
		}

		[Property ("window")]
		//The widget's window if it is realized, NULL otherwise.
		public Gdk.Window Window{
			get{
				IntPtr o = Widget.gtk_widget_get_window (base.Handle);
				return GLib.Object.GetObject(o) as Gdk.Window;
			}
		}


		#endregion

		public Atk.Object RefAccessible ()
		{
			IntPtr o = Widget.atk_implementor_ref_accessible (base.Handle);
			return new Atk.Object(o);
		}

		#region Constructors
		protected Widget () : base (IntPtr.Zero)
		{
			//this.CreateNativeObject (new string[0], new GLib.Value[0]);
		}

		public Widget (IntPtr raw) : base (raw)
		{
		}

		#endregion

		#region Methods

		public void Show ()
		{
			Widget.gtk_widget_show (base.Handle);
		}

		public void ShowAll ()
		{
			Widget.gtk_widget_show_all (base.Handle);
		}

		#endregion
		#region Callbacks for native signals

		[CDeclCallback]
		private delegate bool ButtonPressEventVMDelegate (IntPtr widget, IntPtr evnt);

		private static Widget.ButtonPressEventVMDelegate ButtonPressEventVMCallback;

		[DllImport ("/usr/lib/cli/gtk-sharp-2.0/libgtksharpglue-2.so")]
		private static extern bool gtksharp_widget_base_button_press_event (IntPtr widget, IntPtr evnt);

		[DllImport ("/usr/lib/cli/gtk-sharp-2.0/libgtksharpglue-2.so")]
		private static extern void gtksharp_widget_override_button_press_event (IntPtr gtype, Widget.ButtonPressEventVMDelegate cb);


		[DefaultSignalHandler (Type = typeof(Widget), ConnectionMethod = "OverrideButtonPressEvent")]
		protected virtual bool OnButtonPressEvent (EventButton evnt)
		{
			return Widget.gtksharp_widget_base_button_press_event (base.Handle, (evnt != null) ? evnt.Handle : IntPtr.Zero);
		}
		private static bool buttonpressevent_cb (IntPtr widget, IntPtr evnt)
		{
			bool result;
			try {
				Widget widget2 = GLib.Object.GetObject (widget, false) as Widget;
				result = widget2.OnButtonPressEvent (new EventButton (evnt));
			}
			catch (Exception ex) {
				ExceptionManager.RaiseUnhandledException (ex, true);
				throw ex;
			}
			return result;
		}

		private static void OverrideButtonPressEvent (GType gtype)
		{
			if (Widget.ButtonPressEventVMCallback == null) {
				Widget.ButtonPressEventVMCallback = new Widget.ButtonPressEventVMDelegate (Widget.buttonpressevent_cb);
			}
			Widget.gtksharp_widget_override_button_press_event (gtype.Val, Widget.ButtonPressEventVMCallback);
		}

		#endregion

		#region Native widget's signals

		[Signal ("accel-closures-changed")]
		//
		public event EventHandler AccelClosuresChanged {
			add {
				Signal signal = Signal.Lookup (this, "accel-closures-changed");
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "accel-closures-changed");
				signal.RemoveDelegate (value);
			}
		}

		[Signal ("button-press-event")]
		// Signal will be emitted when a button (typically from a mouse) is pressed.
		public event ButtonPressEventHandler ButtonPressEvent {
			add {
				Signal signal = Signal.Lookup (this, "button-press-event", typeof(ButtonPressEventArgs));
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "button-press-event", typeof(ButtonPressEventArgs));
				signal.RemoveDelegate (value);
			}
		}


		[Signal ("button-release-event")]
		// Signal will be emitted when a button (typically from a mouse) is released.
		public event ButtonReleaseEventHandler ButtonReleaseEvent {
			add {
				Signal signal = Signal.Lookup (this, "button-release-event", typeof(ButtonReleaseEventArgs));
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "button-release-event", typeof(ButtonReleaseEventArgs));
				signal.RemoveDelegate (value);
			}
		}

	

		[Signal ("child-notify")]
		//Signal is emitted for each child property that has changed on an object. 
		public event ChildNotifiedHandler ChildNotified {
			add {
				Signal signal = Signal.Lookup (this, "child-notify", typeof(ChildNotifiedArgs));
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "child-notify", typeof(ChildNotifiedArgs));
				signal.RemoveDelegate (value);
			}
		}


		[Signal ("composited-changed")]
		//Signal is emitted when the composited status of widgets screen changes.
		public event EventHandler CompositedChanged {
			add {
				Signal signal = Signal.Lookup (this, "composited-changed");
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "composited-changed");
				signal.RemoveDelegate (value);
			}
		}

		[Signal ("configure-event")]
		//Signal will be emitted when the size, position or stacking of the widget 's window has changed.
		public event ConfigureEventHandler ConfigureEvent {
			add {
				Signal signal = Signal.Lookup (this, "configure-event", typeof(ConfigureEventArgs));
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "configure-event", typeof(ConfigureEventArgs));
				signal.RemoveDelegate (value);
			}
		}


		[Signal ("delete-event")]
		// Signal is emitted if a user requests that a toplevel window is closed.
		public event DeleteEventHandler DeleteEvent {
			add {
				Signal signal = Signal.Lookup (this, "delete-event", typeof(DeleteEventArgs));
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "delete-event", typeof(DeleteEventArgs));
				signal.RemoveDelegate (value);
			}
		}

		[Signal ("key_press_event")]
		//Signal is emitted when a key is pressed. 
		public event KeyPressEventHandler KeyPressEvent {
			add {
				Signal signal = Signal.Lookup (this, "key_press_event", typeof(KeyPressEventArgs));
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "key_press_event", typeof(KeyPressEventArgs));
				signal.RemoveDelegate (value);
			}
		}
		#endregion


			}





	}


