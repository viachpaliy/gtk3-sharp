using GLib;
using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

namespace Gtk3
{
	public class Builder : GLib.Object {
		//
		// Native functions
		//
		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_builder_new ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_builder_new_from_file (IntPtr filename);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_builder_new_from_string (IntPtr XMLstring, long length);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint gtk_builder_add_from_file (IntPtr raw, IntPtr filename, out IntPtr error);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint gtk_builder_add_from_string (IntPtr raw, IntPtr buffer, long length, out IntPtr error);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_builder_get_object (IntPtr raw, IntPtr name);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_builder_get_objects (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_builder_get_translation_domain (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_builder_set_translation_domain (IntPtr raw, IntPtr domain);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint gtk_builder_add_objects_from_file (IntPtr raw, IntPtr filename,IntPtr[] objects_array, out IntPtr error);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint gtk_builder_add_objects_from_string (IntPtr raw, IntPtr buffer, long length,IntPtr[] objects_array, out IntPtr error);
		//
		// Constructors
		//
		public Builder () : base (IntPtr.Zero)
		{
			this.Raw = Builder.gtk_builder_new ();
		}

		public Builder (IntPtr raw) : base (raw)
		{
		}

		public static Builder FromFile(string filename)
		{
			IntPtr filenamePtr = Marshaller.StringToFilenamePtr (filename);
			IntPtr o = Builder.gtk_builder_new_from_file (filenamePtr);
			Marshaller.Free (filenamePtr);
			return new Builder (o);
		}

		public static Builder FromTextFile(string filename)
		{
			string XMLtext = System.IO.File.ReadAllText (filename);
			return Builder.FromString (XMLtext);
		}

		public static Builder FromString (string XMLstring)
		{
			IntPtr intPtr = Marshaller.StringToPtrGStrdup (XMLstring);
			IntPtr o = Builder.gtk_builder_new_from_string (intPtr, (long)Encoding.UTF8.GetByteCount (XMLstring));
			Marshaller.Free (intPtr);
			return new Builder (o);
		}

		//
		// Methods
		//
		public uint AddFromFile (string filename)
		{
			IntPtr intPtr = Marshaller.StringToFilenamePtr (filename);
			IntPtr zero = IntPtr.Zero;
			uint num = Builder.gtk_builder_add_from_file (base.Handle, intPtr, out zero);
			//uint result = num;
			Marshaller.Free (intPtr);
			if (zero != IntPtr.Zero) {
				throw new GException (zero);
			}
			return num;
		}

		public uint AddFromTextFile(string filename)
		{
			string buffer = System.IO.File.ReadAllText (filename);
			IntPtr intPtr = Marshaller.StringToPtrGStrdup (buffer);
			IntPtr zero = IntPtr.Zero;
			uint num = Builder.gtk_builder_add_from_string (base.Handle, intPtr,(long)Encoding.UTF8.GetByteCount (buffer), out zero);
			Marshaller.Free (intPtr);
			if (zero != IntPtr.Zero) {
				throw new GException (zero);
			}
			return num;
		}

		public uint AddFromString (string buffer)
		{
			IntPtr intPtr = Marshaller.StringToPtrGStrdup (buffer);
			IntPtr zero = IntPtr.Zero;
			uint num = Builder.gtk_builder_add_from_string (base.Handle, intPtr,(long)Encoding.UTF8.GetByteCount (buffer), out zero);
			//uint result = num;
			Marshaller.Free (intPtr);
			if (zero != IntPtr.Zero) {
				throw new GException (zero);
			}
			return num;
		}

		public uint AddObjectsFromFile(string filename, string[] objectsId)
		{
			IntPtr fnPtr = Marshaller.StringToFilenamePtr (filename);
			IntPtr[] objPtr = Marshaller.StringArrayToNullTermPointer (objectsId); 
			IntPtr zero = IntPtr.Zero;
			uint num = Builder.gtk_builder_add_objects_from_file (base.Handle, fnPtr, objPtr, out zero);
			Marshaller.Free (fnPtr);
			Marshaller.Free (objPtr);
			if (zero != IntPtr.Zero) {
				throw new GException (zero);
			}
			return num;
		}

		public uint AddObjectsFromString(string XMLstring, string[] objectsId)
		{
			IntPtr xmlPtr = Marshaller.StringToPtrGStrdup (XMLstring);
			IntPtr[] objPtr = Marshaller.StringArrayToNullTermPointer (objectsId); 
			IntPtr zero = IntPtr.Zero;
			uint num = Builder.gtk_builder_add_objects_from_string (base.Handle, xmlPtr,(long)Encoding.UTF8.GetByteCount (XMLstring), objPtr, out zero);
			Marshaller.Free (xmlPtr);
			Marshaller.Free (objPtr);
			if (zero != IntPtr.Zero) {
				throw new GException (zero);
			}
			return num;
		}



		public GLib.Object GetObject (string name)
		{
			IntPtr intPtr = Marshaller.StringToPtrGStrdup (name);
			IntPtr o = Builder.gtk_builder_get_object (base.Handle, intPtr);
			GLib.Object @object = GLib.Object.GetObject (o);
			Marshaller.Free (intPtr);
			return @object;
		}

		public Gtk3.Widget GetWidget (string name)
		{
			IntPtr intPtr = Marshaller.StringToPtrGStrdup (name);
			IntPtr o = Builder.gtk_builder_get_object (base.Handle, intPtr);
			Gtk3.Widget widget = GLib.Object.GetObject (o) as Gtk3.Widget;
			if(widget==null) {widget = new Gtk3.Widget (o);}
			Marshaller.Free (intPtr);
			return widget;
		}

		//
		// Properties
		//
		public GLib.Object[] Objects {
			get {
				IntPtr list_ptr = Builder.gtk_builder_get_objects (base.Handle);
				return (GLib.Object[])Marshaller.ListPtrToArray (list_ptr, typeof(SList), true, false, typeof(GLib.Object));
			}
		}

		[Property ("translation-domain")]
		public string TranslationDomain {
			get {
				IntPtr ptr = Builder.gtk_builder_get_translation_domain (base.Handle);
				return Marshaller.Utf8PtrToString (ptr);
			}
			set {
				IntPtr intPtr = Marshaller.StringToPtrGStrdup (value);
				Builder.gtk_builder_set_translation_domain (base.Handle, intPtr);
				Marshaller.Free (intPtr);
			}
		}







	}
}

	



