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
using Atk;
using Gdk;
using GLib;
using Pango;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Gtk3{

	/// <summary>
	///  Base class for all widgets.
	/// </summary>
	public class Widget:GLib.InitiallyUnowned,IBuildable, Implementor, IWrapper{
					
			
		#region Private Static Methods

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

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_widget_get_style_context (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_widget_reset_style (IntPtr raw);

		#endregion

		#region IBuildable implementation

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_buildable_set_name (IntPtr buildable, IntPtr name);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_buildable_get_name (IntPtr buildable);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_buildable_add_child (IntPtr buildable, IntPtr builder, IntPtr child, IntPtr type);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_buildable_construct_child (IntPtr buildable, IntPtr builder, IntPtr name);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_buildable_custom_tag_end (IntPtr buildable, IntPtr builder, IntPtr child, IntPtr tagname, IntPtr data);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_buildable_custom_finished (IntPtr buildable, IntPtr builder, IntPtr child, IntPtr tagname, IntPtr data);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_buildable_parser_finished (IntPtr buildable, IntPtr builder);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_buildable_get_internal_child (IntPtr buildable, IntPtr builder, IntPtr childname);

		void IBuildable.SetName (string name)
		{
			IntPtr namePtr = Marshaller.StringToPtrGStrdup (name);
			Widget.gtk_buildable_set_name (base.Handle, namePtr);
			Marshaller.Free (namePtr);
		}

		string IBuildable.GetName()
		{
			IntPtr namePtr=Widget.gtk_buildable_get_name(base.Handle);
			return Marshaller.Utf8PtrToString (namePtr);
		}

		void IBuildable.AddChild (Builder builder,Widget child, string type)
		{
			IntPtr typePtr = Marshaller.StringToPtrGStrdup (type);
			Widget.gtk_buildable_add_child (base.Handle, builder.Handle, child.Handle, typePtr);
			Marshaller.Free (typePtr);
		}

		void IBuildable.AddChild (Builder builder,Widget child)
		{
			Widget.gtk_buildable_add_child (base.Handle, builder.Handle, child.Handle, IntPtr.Zero);
		}

		GLib.Object IBuildable.ConstructChild (Builder builder, string name)
		{
			IntPtr namePtr = Marshaller.StringToPtrGStrdup (name);
			IntPtr o=Widget.gtk_buildable_construct_child (base.Handle, builder.Handle, namePtr);
			Marshaller.Free (namePtr);
			return GLib.Object.GetObject (o);

		}

		void IBuildable.CustomTagEnd (Builder builder, Widget child, string tagname, string data)
		{
			IntPtr tagnamePtr = Marshaller.StringToPtrGStrdup (tagname);
			IntPtr dataPtr = Marshaller.StringToPtrGStrdup (data);
			Widget.gtk_buildable_custom_tag_end (base.Handle, builder.Handle, child.Handle, tagnamePtr, dataPtr);
			Marshaller.Free (tagnamePtr);
			Marshaller.Free (dataPtr);
		}	

		void IBuildable.CustomFinished (Builder builder, Widget child, string tagname, string data)
		{
			IntPtr tagnamePtr = Marshaller.StringToPtrGStrdup (tagname);
			IntPtr dataPtr = Marshaller.StringToPtrGStrdup (data);
			Widget.gtk_buildable_custom_finished(base.Handle, builder.Handle, child.Handle, tagnamePtr, dataPtr);
			Marshaller.Free (tagnamePtr);
			Marshaller.Free (dataPtr);
		}

		void IBuildable.ParserFinished (Builder builder)
		{
			Widget.gtk_buildable_parser_finished (base.Handle, builder.Handle);
		}

		GLib.Object IBuildable.GetInternalChild (Builder builder, string childname)
		{
			IntPtr namePtr = Marshaller.StringToPtrGStrdup (childname);
			IntPtr o=Widget.gtk_buildable_get_internal_child (base.Handle, builder.Handle, namePtr);
			Marshaller.Free (namePtr);
			return GLib.Object.GetObject (o);
		}

		#endregion


		#region Properties
	
		/// <summary>
		/// //Whether the application will paint directly on the widget.
		/// </summary>
		/// <value><c>true</c> if app will paint directly on the widget; otherwise, <c>false</c>.</value>
		[Property ("app-paintable")]
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

		/// <summary>
		/// Whether the widget can be the default widget.
		/// </summary>
		/// <value><c>true</c> if this widget can default widget; otherwise, <c>false</c>.</value>
		[Property ("can-default")]
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

		/// <summary>
		/// Whether the widget can accept the input focus.
		/// </summary>
		/// <value><c>true</c> if this widget can accept the input focus.; otherwise, <c>false</c>.</value>
		[Property ("can-focus")]
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

		/// <summary>
		/// //Whether the widget is part of a composite widget.
		/// </summary>
		/// <value><c>true</c> if this widget is part of a composite widget; otherwise, <c>false</c>.</value>
		[Property ("composite-child")]
		public bool CompositeChild {
			get {
				GLib.Value property = base.GetProperty ("composite-child");
				bool result = (bool)property;
				property.Dispose ();
				return result;
			}
		}

		/// <summary>
		/// The event mask that decides what kind of GdkEvents this widget gets.
		/// </summary>
		/// <value>The event mask.</value>
		[Property ("events")]
		public EventMask Events {
			get {
				return (EventMask)Widget.gtk_widget_get_events (base.Handle);
			}
			set {
				Widget.gtk_widget_set_events (base.Handle, (int)value);
			}
		}

		/// <summary>
		/// Whether to expand in both directions. Setting this sets both “hexpand” and “vexpand”
		/// </summary>
		/// <value><c>true</c> if expand; otherwise, <c>false</c>.</value>
		[Property ("expand")]
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

		/// <summary>
		/// Whether the widget should grab focus when it is clicked with the mouse.
		/// </summary>
		[Property ("focus-on-click")]
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

		/// <summary>
		/// How to distribute horizontal space if widget gets extra space.
		/// </summary>
		[Property ("halign")]
		public Align Halign {
			get {
				return (Align)Widget.gtk_widget_get_halign (base.Handle);
			}
			set {
				Widget.gtk_widget_set_halign (base.Handle, (int)value);
			}
		}

		/// <summary>
		/// Whether the widget is the default widget.
		/// </summary>
		/// <value><c>true</c> if this widget is the default widget; otherwise, <c>false</c>.</value>
		[Property ("has-default")]
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

		/// <summary>
		/// Whether the widget has the input focus.
		/// </summary>
		/// <value><c>true</c> if this widget has the input focus; otherwise, <c>false</c>.</value>
		[Property ("has-focus")]
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

		/// <summary>
		/// Enables or disables the emission of “query-tooltip” on widget .
		/// </summary>
		/// <value><c>true</c>  indicates that widget can have a tooltip,
		///  in this case the widget will be queried using “query-tooltip” 
		/// to determine whether it will provide a tooltip or not.</value>
		[Property ("has-tooltip")]
		public bool HasTooltip {
			get {
				return Widget.gtk_widget_get_has_tooltip (base.Handle);
			}
			set {
				Widget.gtk_widget_set_has_tooltip (base.Handle, value);
			}
		}

		/// <summary>
		/// Override for height request of the widget, or -1 if natural request should be used.
		/// </summary>
		/// <value>Allowed values: >= -1.Default value: -1 </value>
		[Property ("height-request")]
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

		/// <summary>
		/// Whether to expand horizontally. 
		/// </summary>
		[Property ("hexpand")]
		public bool Hexpand {
			get {
				return Widget.gtk_widget_get_hexpand(base.Handle);
			}
			set {
				Widget.gtk_widget_set_hexpand (base.Handle, value);
			}
		}

		/// <summary>
		/// Whether to use the “hexpand” property.
		/// </summary>
		[Property ("hexpand-set")]
		public bool HexpandSet {
			get {
				return Widget.gtk_widget_get_hexpand_set(base.Handle);
			}
			set {
				Widget.gtk_widget_set_hexpand_set (base.Handle, value);
			}
		}


		/// <summary>
		/// Whether the widget is the focus widget within the toplevel.
		/// </summary>
		[Property ("is-focus")]
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

		/// <summary>
		/// Sets all four sides' margin at once. If read, returns max margin on any side.
		/// </summary>
		/// <value>The margin.</value>
		[Property ("margin")]
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

		/// <summary>
		/// Margin on bottom side of widget.
		/// </summary>
		[Property ("margin-bottom")]
		public int MarginBottom {
			get {
				return Widget.gtk_widget_get_margin_bottom(base.Handle);
			}
			set {
				Widget.gtk_widget_set_margin_bottom (base.Handle, value);
			}
		}

		/// <summary>
		/// Margin on end of widget, horizontally. 
		/// </summary>
		[Property ("margin-end")]
		public int MarginEnd {
			get {
				return Widget.gtk_widget_get_margin_end(base.Handle);
			}
			set {
				Widget.gtk_widget_set_margin_end (base.Handle, value);
			}
		}

		/// <summary>
		/// Margin on start of widget, horizontally.  
		/// </summary>
		[Property ("margin-start")]
		public int MarginStart {
			get {
				return Widget.gtk_widget_get_margin_start(base.Handle);
			}
			set {
				Widget.gtk_widget_set_margin_start (base.Handle, value);
			}
		}

		/// <summary>
		/// Margin on top side of widget.
		/// </summary>
        [Property ("margin-top")]
		public int MarginTop {
			get {
				return Widget.gtk_widget_get_margin_top(base.Handle);
			}
			set {
				Widget.gtk_widget_set_margin_top (base.Handle, value);
			}
		}


		/// <summary>
		///The name of the widget.
		/// </summary>
		[Property ("name")]
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

		/// <summary>
		/// Whether gtk_widget_show_all() should not affect this widget.
		/// </summary>
		[Property ("no-show-all")]
		public bool NoShowAll {
			get {
				return Widget.gtk_widget_get_no_show_all (base.Handle);
			}
			set {
				Widget.gtk_widget_set_no_show_all (base.Handle, value);
			}
		}
		
		/// <summary>
		/// The requested opacity of the widget. 
		/// </summary>
		[Property ("opacity")]
		public double Opacity {
			get{
				return Widget.gtk_widget_get_opacity (base.Handle);
			}
			set {
				Widget.gtk_widget_set_opacity (base.Handle, value);
			}
		}
	
		/// <summary>
		///The parent widget of this widget. Must be a Container widget.
		/// </summary>
		[Property ("parent")]
		public Container Parent {
			get {
			IntPtr o = Widget.gtk_widget_get_parent (base.Handle);
				return GLib.Object.GetObject(o) as Container;
			}
			set {
				Widget.gtk_widget_set_parent (base.Handle, (value != null) ? value.Handle : IntPtr.Zero);
			}
		}
		
		/// <summary>
		///If TRUE, the widget will receive the default action when it is focused.
		/// </summary>
		[Property ("receives-default")]
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
		
		/// <summary>
		///Retrieves the internal scale factor that maps from window coordinates to the actual device pixels.
		///On traditional systems this is 1, on high density outputs, it can be a higher value (typically 2).
		/// </summary>
		[Property ("scale-factor")]
		public int ScaleFactor {
			get{
				return Widget.gtk_widget_get_scale_factor (base.Handle);
			}
		}

		/// <summary>
		///Whether the widget responds to input.
		/// </summary>
		[Property ("sensitive")]
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
	
		/// <summary>
		///Sets the text of tooltip to be the given string, which is marked up with the Pango text markup language.
		/// </summary>
		[Property ("tooltip-markup")]
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
		
		/// <summary>
		///Sets the text of tooltip to be the given string.
		/// </summary>
		[Property ("tooltip-text")]
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

		/// <summary>
		///How to distribute vertical space if widget gets extra space.
		/// </summary>
		[Property ("valign")]
		public Align Valign {
			get {
				return (Align)Widget.gtk_widget_get_valign (base.Handle);
			}
			set {
				Widget.gtk_widget_set_valign (base.Handle, (int)value);
			}
		}
		
		/// <summary>
		///Whether to expand vertically.
		/// </summary>
		[Property ("vexpand")]
		public bool Vexpand {
			get {
				return Widget.gtk_widget_get_vexpand(base.Handle);
			}
			set {
				Widget.gtk_widget_set_vexpand (base.Handle, value);
			}
		}

		/// <summary>
		///Whether to use "vexpand" property.
		/// </summary>
		[Property ("vexpand-set")]
		public bool VexpandSet {
			get {
				return Widget.gtk_widget_get_vexpand_set(base.Handle);
			}
			set {
				Widget.gtk_widget_set_vexpand_set (base.Handle, value);
			}
		}

		/// <summary>
		///Whether the widget is visible.
		/// </summary>
		[Property ("visible")]
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
		
		/// <summary>
		///Override for width request of the widget, or -1 if natural request should be used.
		/// </summary>
		[Property ("width-request")]
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
		
		/// <summary>
		///The widget's window if it is realized, NULL otherwise.
		/// </summary>
		[Property ("window")]
		public Gdk.Window Window{
			get{
				IntPtr o = Widget.gtk_widget_get_window (base.Handle);
				return GLib.Object.GetObject(o) as Gdk.Window;
			}
		}


		#endregion
		#region Shapr widget's properties

		public Gdk.Screen Screen {
			get {
				IntPtr o = Widget.gtk_widget_get_screen (base.Handle);
				return GLib.Object.GetObject (o) as Gdk.Screen;
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

		public Gtk3.StyleContext GetStyleContext()
		{
			IntPtr o = Widget.gtk_widget_get_style_context (base.Handle);
			Gtk3.StyleContext context= GLib.Object.GetObject (o) as Gtk3.StyleContext;
			if (context == null) {
				context = new StyleContext (o);
			}
			return context;
		}

		public void ResetStyle()
		{
			Widget.gtk_widget_reset_style (base.Handle);
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

		[Signal ("can-activate-accel")]
		//Determines whether an accelerator that activates the signal
		//identified by signal_id can currently be activated. 
		public event CanActivateAccelHandler CanActivateAccel{
			add {
				Signal signal = Signal.Lookup (this, "can-activate-accel", typeof(CanActivateAccelArgs));
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "can-activate-accel", typeof(CanActivateAccelArgs));
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

		[Signal ("key-press-event")]
		//Signal is emitted when a key is pressed. 
		public event KeyPressEventHandler KeyPressEvent {
			add {
				Signal signal = Signal.Lookup (this, "key-press-event", typeof(KeyPressEventArgs));
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "key-press-event", typeof(KeyPressEventArgs));
				signal.RemoveDelegate (value);
			}
		}
		#endregion


			}





	}


