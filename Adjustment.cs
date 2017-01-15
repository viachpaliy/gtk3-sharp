using GLib;
using System;
using System.Runtime.InteropServices;

namespace Gtk3
{
	public class Adjustment : GLib.InitiallyUnowned
	{
		//
		// Static Methods
		//

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

		//
		// Properties
		//
		[Property ("lower")]
		public double Lower {
			get{ 
				return Adjustment.gtk_adjustment_get_lower (base.Handle);
			}
			set{
				Adjustment.gtk_adjustment_set_lower (base.Handle, value);
			}

		}

		[Property ("page-increment")]
		public double PageIncrement {
			get{
				return Adjustment.gtk_adjustment_get_page_increment (base.Handle);
			}
			set{
				Adjustment.gtk_adjustment_set_page_increment (base.Handle, value);
			}

		}

		[Property ("page-size")]
		public double PageSize {
			get{
				return Adjustment.gtk_adjustment_get_page_size (base.Handle);
			}
			set{
				Adjustment.gtk_adjustment_set_page_size (base.Handle, value);
			}
		}

		[Property ("step-increment")]
		public double StepIncrement {
			get{
				return Adjustment.gtk_adjustment_get_step_increment (base.Handle);
			}
			set{
				Adjustment.gtk_adjustment_set_step_increment (base.Handle, value);
			}
		}

		[Property ("upper")]
		public double Upper {
			get{
				return Adjustment.gtk_adjustment_get_upper (base.Handle);
			}
			set{
				Adjustment.gtk_adjustment_set_upper (base.Handle, value);
			}
		}

		[Property ("value")]
		public double Value {
			get{
				return Adjustment.gtk_adjustment_get_value (base.Handle);			
			}
			set{
				Adjustment.gtk_adjustment_set_value (base.Handle, value);
			}
		}



		//
		// Constructors
		//

		public Adjustment (double value, double lower, double upper, double step_increment, double page_increment, double page_size) : base (IntPtr.Zero)
		{
			this.Raw = Adjustment.gtk_adjustment_new (value, lower, upper, step_increment, page_increment, page_size);
		}

		public Adjustment (IntPtr raw) : base (raw)
		{
		}

		protected Adjustment () : base (IntPtr.Zero){
		}
	
		//
		// Methods
		//

		public void ClampPage (double lower, double upper)
		{
			Adjustment.gtk_adjustment_clamp_page (base.Handle, lower, upper);
		}

		public void Configure (double value, double lower, double upper, double step_increment, double page_increment, double page_size)
		{
			Adjustment.gtk_adjustment_configure (base.Handle, value, lower, upper, step_increment, page_increment, page_size);
		}

		public double GetMinimumIncrement()
		{
			return Adjustment.gtk_adjustment_get_minimum_increment (base.Handle);
		}


		//
		// Signals
		//

		[Signal ("changed")]
		//Emitted when one or more of the GtkAdjustment properties have been changed,
		//other than the “value” property.
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

		[Signal ("value-changed")]
		//Emitted when the “value” property has been changed.
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


	}



}