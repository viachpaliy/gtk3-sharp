using GLib;
using System;
using System.Runtime.InteropServices;

namespace Gtk3
{
	public class Grid : Container,IOrientable
	{

		//
		//  IOrientable interface
		//

		void IOrientable.SetOrientation(Orientation orientation)
		{
			Grid.gtk_orientable_set_orientation (base.Handle, (int)orientation);
		}

		Orientation IOrientable.GetOrientation()
		{
			return (Orientation)Grid.gtk_orientable_get_orientation (base.Handle);
		}
		//
		// Static Methods
		//
		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_grid_new ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_orientable_get_orientation (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_orientable_set_orientation (IntPtr raw, int orientation);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_attach (IntPtr raw, IntPtr child, int left, int top, int width, int height);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_attach_next_to (IntPtr raw, IntPtr child, IntPtr sibling, int side, int width, int height);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_grid_get_child_at (IntPtr raw, int left, int top);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_insert_row (IntPtr raw, int position);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_insert_column (IntPtr raw, int position);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_remove_row (IntPtr raw, int position);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_remove_column (IntPtr raw, int position);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_insert_next_to (IntPtr raw, IntPtr sibling, int side);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_set_row_homogeneous (IntPtr raw, bool homogeneous);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_grid_get_row_homogeneous (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_set_row_spacing (IntPtr raw, uint spacing);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint gtk_grid_get_row_spacing (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_set_column_homogeneous (IntPtr raw, bool homogeneous);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_grid_get_column_homogeneous (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_set_column_spacing (IntPtr raw, uint spacing);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint gtk_grid_get_column_spacing (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_grid_get_baseline_row (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_set_baseline_row (IntPtr raw, int row);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_grid_get_row_baseline_position (IntPtr raw, int row);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_grid_set_row_baseline_position (IntPtr raw, int row, int pos);

		//
		//  Constructors
		//


		public Grid(): base(IntPtr.Zero)
		{
			this.Raw = Grid.gtk_grid_new ();
		}

		public Grid(IntPtr raw) : base(IntPtr.Zero)
		{
			this.Raw = raw;
		}

		//
		//	Properties
		//

		[Property ("baseline-row")]
		//The row to align the to the baseline when valign is Align.Baseline(GTK_ALIGN_BASELINE).
		public int BaselineRow {
			get {
				return Grid.gtk_grid_get_baseline_row (base.Handle);
			}
			set {
				Grid.gtk_grid_set_baseline_row (base.Handle, value);
			}
		}

		[Property ("column-homogeneous")]
		//If TRUE, the columns are all the same width.
		public bool ColumnHomogeneous {
			get{
				return Grid.gtk_grid_get_column_homogeneous (base.Handle);
			}
			set {
				Grid.gtk_grid_set_column_homogeneous (base.Handle, value);
			}
		}






	}

}
