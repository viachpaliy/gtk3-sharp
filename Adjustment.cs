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
	/// <summary>
	/// A representation of an adjustable bounded value.
	/// </summary>
	public class Adjustment : GLib.InitiallyUnowned
	{
		
		#region Static Methods

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_adjustment_new (double value, double lower, double upper, double step_increment, double page_increment, double page_size);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double gtk_adjustment_get_value (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_adjustment_set_value (IntPtr raw, double value);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_adjustment_clamp_page (IntPtr raw, double lower, double upper);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_adjustment_configure (IntPtr raw, double value, double lower, double upper, double step_increment, double page_increment, double page_size);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double gtk_adjustment_get_lower (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double gtk_adjustment_get_page_increment (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double gtk_adjustment_get_page_size (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double gtk_adjustment_get_step_increment (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double gtk_adjustment_get_minimum_increment (IntPtr raw); 

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double gtk_adjustment_get_upper (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_adjustment_set_lower (IntPtr raw, double lower);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_adjustment_set_page_increment (IntPtr raw, double page_increment);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_adjustment_set_page_size (IntPtr raw, double page_size);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_adjustment_set_step_increment (IntPtr raw, double step_increment);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_adjustment_set_upper (IntPtr raw, double upper);

		#endregion

		#region Properties
		/// <summary>
		/// The minimum value of the adjustment.
		/// </summary>
		[Property ("lower")]
		public double Lower {
			get{ 
				return Adjustment.gtk_adjustment_get_lower (base.Handle);
			}
			set{
				Adjustment.gtk_adjustment_set_lower (base.Handle, value);
			}

		}
		/// <summary>
		/// The page increment of the adjustment.
		/// </summary>
		[Property ("page-increment")]
		public double PageIncrement {
			get{
				return Adjustment.gtk_adjustment_get_page_increment (base.Handle);
			}
			set{
				Adjustment.gtk_adjustment_set_page_increment (base.Handle, value);
			}

		}
		/// <summary>
		/// The page size of the adjustment.
		/// </summary>
		[Property ("page-size")]
		public double PageSize {
			get{
				return Adjustment.gtk_adjustment_get_page_size (base.Handle);
			}
			set{
				Adjustment.gtk_adjustment_set_page_size (base.Handle, value);
			}
		}
		/// <summary>
		/// The step increment of the adjustment.
		/// </summary>
		[Property ("step-increment")]
		public double StepIncrement {
			get{
				return Adjustment.gtk_adjustment_get_step_increment (base.Handle);
			}
			set{
				Adjustment.gtk_adjustment_set_step_increment (base.Handle, value);
			}
		}
		/// <summary>
		/// The maximum value of the adjustment.
		/// </summary>
		[Property ("upper")]
		public double Upper {
			get{
				return Adjustment.gtk_adjustment_get_upper (base.Handle);
			}
			set{
				Adjustment.gtk_adjustment_set_upper (base.Handle, value);
			}
		}
		/// <summary>
		/// The value of the adjustment.
		/// </summary>
		[Property ("value")]
		public double Value {
			get{
				return Adjustment.gtk_adjustment_get_value (base.Handle);			
			}
			set{
				Adjustment.gtk_adjustment_set_value (base.Handle, value);
			}
		}

		#endregion

		#region Constructors
		/// <summary>
		/// Creates an Adjustment with the specified value and bounds.
		/// </summary>
		/// <param name="value">The value of the adjustment.</param>
		/// <param name="lower">The minimum value of the adjustment.</param>
		/// <param name="upper">The maximum value of the adjustment.</param>
		/// <param name="step_increment">The step increment of the adjustment.</param>
		/// <param name="page_increment">The page increment of the adjustment.</param>
		/// <param name="page_size">The page size of the adjustment.</param>
		public Adjustment (double value, double lower, double upper, double step_increment, double page_increment, double page_size) : base (IntPtr.Zero)
		{
			this.Raw = Adjustment.gtk_adjustment_new (value, lower, upper, step_increment, page_increment, page_size);
		}

		/// <summary>
		///Internal constructor.Constructs the object from a C-based pointer.
		/// </summary>
		/// <param name="raw">The raw GObject reference associated with this object.</param>
		public Adjustment (IntPtr raw) : base (raw)
		{
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected Adjustment () : base (IntPtr.Zero){
		}
	
		#endregion
		//
		#region Public Methods

		/// <summary>
		/// Updates the “value” property to ensure that the range between lower and upper is in the current page 
		/// (i.e. between “value” and “value” + “page-size”).
		/// </summary>
		/// <param name="lower">The minimum value of the adjustment.</param>
		/// <param name="upper">The maximum value of the adjustment.</param>
		public void ClampPage (double lower, double upper)
		{
			Adjustment.gtk_adjustment_clamp_page (base.Handle, lower, upper);
		}
		/// <summary>
		/// Sets all properties of the adjustment at once.
		/// </summary>
		/// <param name="value">The value of the adjustment.</param>
		/// <param name="lower">The minimum value of the adjustment.</param>
		/// <param name="upper">The maximum value of the adjustment.</param>
		/// <param name="step_increment">The step increment of the adjustment.</param>
		/// <param name="page_increment">The page increment of the adjustment.</param>
		/// <param name="page_size">The page size of the adjustment.</param>
		public void Configure (double value, double lower, double upper, double step_increment, double page_increment, double page_size)
		{
			Adjustment.gtk_adjustment_configure (base.Handle, value, lower, upper, step_increment, page_increment, page_size);
		}
		/// <summary>
		/// Gets the smaller of step increment and page increment.
		/// </summary>
		/// <returns>The minimum increment of adjustment</returns>
		public double GetMinimumIncrement()
		{
			return Adjustment.gtk_adjustment_get_minimum_increment (base.Handle);
		}

		#endregion
		//
		#region Events

		/// <summary>
		/// This event is raised when one or more of the GtkAdjustment properties have been changed,
		///other than the “value” property.
		/// </summary>
		[Signal ("changed")]
		public event EventHandler Changed {
			add {
				Signal signal = Signal.Lookup (this, "changed");
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "changed");
				signal.RemoveDelegate (value);
			}
		}
	
		/// <summary>
		/// This event is raised when the “value” property has been changed.
		/// </summary>
		[Signal ("value-changed")]
		public event EventHandler ValueChanged {
			add {
				Signal signal = Signal.Lookup (this, "value-changed");
				signal.AddDelegate (value);
			}
			remove {
				Signal signal = Signal.Lookup (this, "value-changed");
				signal.RemoveDelegate (value);
			}
		}

		#endregion
	}



}