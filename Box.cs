using GLib;
using System;
using System.Runtime.InteropServices;

namespace Gtk3
{
	public class Box : Container
	{

		//
		// Constructors
		//

		protected Box () : base (IntPtr.Zero){}

		public Box (IntPtr raw) : base (raw){}

		public Box (Orientation orientation, int spasing): base (IntPtr.Zero){

			this.Raw = Box.gtk_box_new ((int)orientation, spasing);
		}

		//
		// Properties
		//

		[Property ("baseline-position")]
		//The position of the baseline aligned widgets if extra space is available.
		public BaselinePosition BaselinePosition {
			get {
				return (BaselinePosition)Box.gtk_box_get_baseline_position (base.Handle);
			}
			set {
				Box.gtk_box_set_baseline_position (base.Handle,(int) value);
			}
		}


		[Property ("homogeneous")]
		//Whether the children should all be the same size.
		public bool Homogeneous {
			get {
				return Box.gtk_box_get_homogeneous (base.Handle);
			}
			set {
				Box.gtk_box_set_homogeneous (base.Handle, value);
			}
		}

		[Property ("spacing")]
		//The amount of space between children.
		public int Spacing {
			get {
				return Box.gtk_box_get_spacing (base.Handle);
			}
			set {
				Box.gtk_box_set_spacing (base.Handle, value);
			}
		}

		//
		// Static Methods
		//

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_box_new (int orientation, int spacing);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_box_get_baseline_position (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_box_get_homogeneous (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_box_get_spacing (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_box_pack_end (IntPtr raw, IntPtr child, bool expand, bool fill, uint padding);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_box_pack_start (IntPtr raw, IntPtr child, bool expand, bool fill, uint padding);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_box_query_child_packing (IntPtr raw, IntPtr child, out bool expand, out bool fill, out uint padding, out int pack_type);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_box_reorder_child (IntPtr raw, IntPtr child, int position);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_box_set_child_packing (IntPtr raw, IntPtr child, bool expand, bool fill, uint padding, int pack_type);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_box_set_baseline_position (IntPtr raw, int position);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_box_set_homogeneous (IntPtr raw, bool homogeneous);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_box_set_spacing (IntPtr raw, int spacing);

		//
		// Methods
		//
		public void PackEnd (Widget child, bool expand, bool fill, uint padding)
		{
			Box.gtk_box_pack_end (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, expand, fill, padding);
		}

		public void PackStart (Widget child, bool expand, bool fill, uint padding)
		{
			Box.gtk_box_pack_start (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, expand, fill, padding);
		}

		public void QueryChildPacking (Widget child, out bool expand, out bool fill, out uint padding, out PackType pack_type)
		{
			int num;
			Box.gtk_box_query_child_packing (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, out expand, out fill, out padding, out num);
			pack_type = (PackType)num;
		}

		public void ReorderChild (Widget child, int position)
		{
			Box.gtk_box_reorder_child (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, position);
		}

		public void SetChildPacking (Widget child, bool expand, bool fill, uint padding, PackType pack_type)
		{
			Box.gtk_box_set_child_packing (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, expand, fill, padding, (int)pack_type);
		}



	}
}