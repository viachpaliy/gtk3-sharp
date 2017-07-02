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
	public class Box : Container,IOrientable
	{

		#region Constructors
		/// <summary>
		/// Default constructor.
		/// </summary>
		protected Box () : base (IntPtr.Zero){}
		/// <summary>
		///Internal constructor.Constructs the object from a C-based pointer.
		/// </summary>
		/// <param name="raw">The raw GObject reference associated with this object.</param>
		public Box (IntPtr raw) : base (raw){}
		/// <summary>
		/// Creates a new Gtk3.Box.
		/// </summary>
		/// <param name="orientation">The box’s orientation.</param>
		/// <param name="spasing">The number of pixels to place by default between children.</param>
		public Box (Orientation orientation, int spasing): base (IntPtr.Zero){

			this.Raw = Box.gtk_box_new ((int)orientation, spasing);
		}

		#endregion

		#region  IOrientable interface
		/// <summary>
		///Sets the orientation of the IOrientable .
		/// </summary>
		/// <param name="orientation">The IOrientable’s new orientation.</param>
		 void IOrientable.SetOrientation(Orientation orientation)
		{
			Box.gtk_orientable_set_orientation (base.Handle, (int)orientation);
		}
		/// <summary>
		/// Retrieves the orientation of the IOrientable .
		/// </summary>
		/// <returns>The orientation of the IOrientable .</returns>
		 Orientation IOrientable.GetOrientation()
		{
			return (Orientation)Box.gtk_orientable_get_orientation (base.Handle);
		}

		#endregion

		#region Properties
		/// <summary>
		/// The position of the baseline aligned widgets if extra space is available.
		/// </summary>
		[Property ("baseline-position")]
		public BaselinePosition BaselinePosition {
			get {
				return (BaselinePosition)Box.gtk_box_get_baseline_position (base.Handle);
			}
			set {
				Box.gtk_box_set_baseline_position (base.Handle,(int) value);
			}
		}

		/// <summary>
		/// Whether the children should all be the same size.
		/// </summary>
		[Property ("homogeneous")]
		public bool Homogeneous {
			get {
				return Box.gtk_box_get_homogeneous (base.Handle);
			}
			set {
				Box.gtk_box_set_homogeneous (base.Handle, value);
			}
		}

		/// <summary>
		/// The amount of space between children.
		/// </summary>
		/// <value>Allowed values: >= 0.</value>
		[Property ("spacing")]
		public int Spacing {
			get {
				return Box.gtk_box_get_spacing (base.Handle);
			}
			set {
				Box.gtk_box_set_spacing (base.Handle, value);
			}
		}

		///<summary>
		///Sets a center widget; that is a child widget that will be
		///centered with respect to the full width of the box, even
		///if the children at either side take up different amounts of space.
		///<summary>
		public Gtk3.Widget CenterWidget {
			get{	
				IntPtr o=Box.gtk_box_get_center_widget (base.Handle);
				Gtk3.Widget widget=GLib.Object.GetObject(o)  as Gtk3.Widget;
				if (o!=null & widget==null) {widget = new Gtk3.Widget(o);}
				return widget;
			}
			set{
				Box.gtk_box_set_center_widget (base.Handle, value.Handle);
			}
		}
		#endregion

		#region Static Methods

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

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_orientable_get_orientation (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_orientable_set_orientation (IntPtr raw, int orientation);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_box_get_center_widget (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_box_set_center_widget (IntPtr raw, IntPtr widget);
		#endregion

		#region Public Methods
		/// <summary>
		/// Adds child to box , packed with reference to the end of box .
		/// </summary>
		/// <param name="child">The Widget to be added to box</param>
		/// <param name="expand"> <c>true</c> if the new child is to be given extra space allocated to box . 
		/// The extra space will be divided evenly between all children of box that use this option</param>
		/// <param name="fill"><c>true</c> if space given to child by the expand option is actually allocated to child ,
		///  rather than just padding it. This parameter has no effect if expand is set to <c>false</c>. 
		/// A child is always allocated the full height of a horizontal GtkBox and the full width of a vertical Box.
		///  This option affects the other dimension</param>
		/// <param name="padding">extra space in pixels to put between this child and its neighbors,
		///  over and above the global amount specified by “spacing” property. </param>
		public void PackEnd (Widget child, bool expand, bool fill, uint padding)
		{
			Box.gtk_box_pack_end (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, expand, fill, padding);
		}
		/// <summary>
		///Adds child to box , packed with reference to the start of box . 
		/// </summary>
		/// <param name="child">The Widget to be added to box</param>
		/// <param name="expand"> <c>true</c> if the new child is to be given extra space allocated to box . 
		/// The extra space will be divided evenly between all children of box that use this option</param>
		/// <param name="fill"><c>true</c> if space given to child by the expand option is actually allocated to child ,
		///  rather than just padding it. This parameter has no effect if expand is set to <c>false</c>. 
		/// A child is always allocated the full height of a horizontal GtkBox and the full width of a vertical Box.
		///  This option affects the other dimension</param>
		/// <param name="padding">extra space in pixels to put between this child and its neighbors,
		///  over and above the global amount specified by “spacing” property. </param>
		public void PackStart (Widget child, bool expand, bool fill, uint padding)
		{
			Box.gtk_box_pack_start (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, expand, fill, padding);
		}
		/// <summary>
		/// Obtains information about how child is packed into box .
		/// </summary>
		/// <param name="child">The Widget of the child to query.</param>
		/// <param name="expand">Return expand child property. </param>
		/// <param name="fill"> Return fill child property. </param>
		/// <param name="padding">Return padding child property.</param>
		/// <param name="pack_type">Return pack-type child property.</param>
		public void QueryChildPacking (Widget child, out bool expand, out bool fill, out uint padding, out PackType pack_type)
		{
			int num;
			Box.gtk_box_query_child_packing (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, out expand, out fill, out padding, out num);
			pack_type = (PackType)num;
		}
		/// <summary>
		/// Moves child to a new position in the list of box children. 
		/// </summary>
		/// <param name="child">The Widget to move</param>
		/// <param name="position">The new position for child in the list of children of box , starting from 0.
		///  If negative, indicates the end of the list</param>
		public void ReorderChild (Widget child, int position)
		{
			Box.gtk_box_reorder_child (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, position);
		}
		/// <summary>
		///Sets the way child is packed into box .
		/// </summary>
		/// <param name="child">The Widget of the child to set</param>
		/// <param name="expand">The new value of the expand child property</param>
		/// <param name="fill">The new value of the fill child property</param>
		/// <param name="padding">The new value of the padding child property</param>
		/// <param name="pack_type">The new value of the pack-type child property</param>
		public void SetChildPacking (Widget child, bool expand, bool fill, uint padding, PackType pack_type)
		{
			Box.gtk_box_set_child_packing (base.Handle, (child != null) ? child.Handle : IntPtr.Zero, expand, fill, padding, (int)pack_type);
		}

		#endregion

	}
}
