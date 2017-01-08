using Gdk;
using GLib;
using Pango;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Gtk3{

	public class CssProvider : GLib.Object {

		#region Gtk+ native functions

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_css_provider_get_default ();

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_css_provider_get_named (IntPtr name, IntPtr variant);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool 	gtk_css_provider_load_from_data (IntPtr css_provider, IntPtr data, long length,IntPtr error);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool 	gtk_css_provider_load_from_file (IntPtr css_provider, IntPtr file, IntPtr error);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool 	gtk_css_provider_load_from_path (IntPtr css_provider, IntPtr path, IntPtr error);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void 	gtk_css_provider_load_from_resource (IntPtr css_provider, IntPtr resource_path);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr 	gtk_css_provider_new ();

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr 	gtk_css_provider_to_string (IntPtr css_provider);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint 	gtk_css_section_get_end_line (IntPtr section);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint gtk_css_section_get_end_position (IntPtr section);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr  gtk_css_section_get_file (IntPtr section);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr  gtk_css_section_get_parent (IntPtr section);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_css_section_get_section_type (IntPtr section);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint	gtk_css_section_get_start_line (IntPtr section);

		[DllImport (Gtk3.Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint	gtk_css_section_get_start_position (IntPtr section);


		[DllImport (Gtk3.Global.GioNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr g_file_new_for_path (IntPtr path);

		#endregion

		#region Methods

		public void LoadFromFile(string file)
		{
			IntPtr fileNamePtr = Marshaller.StringToPtrGStrdup (file);

			IntPtr g_file = g_file_new_for_path (fileNamePtr);

			Gtk3.CssProvider.gtk_css_provider_load_from_file (this.Handle, g_file, IntPtr.Zero);

			Marshaller.Free (fileNamePtr);
			//Marshaller.Free (g_file);
		}

		public void LoadFromData(string data)
		{
			IntPtr dataPtr = Marshaller.StringToPtrGStrdup (data);
			long length = (long)data.Length;
			Gtk3.CssProvider.gtk_css_provider_load_from_data (this.Handle, dataPtr, length, IntPtr.Zero);
			Marshaller.Free (dataPtr);
				}
		#endregion

		#region Constructors
		public CssProvider():base()
		{
			this.Raw =Gtk3.CssProvider.gtk_css_provider_new ();
		}

		public CssProvider(IntPtr raw):base(raw)
		{
			this.Raw = raw;
		}


		#endregion
	}


}
