using GLib;
using System;
using System.Runtime.InteropServices;

namespace Gtk3
{
	public class Revealer : Bin
	{
		//
		// Static Methods
		//
		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr gtk_revealer_new ();

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_revealer_get_reveal_child (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_revealer_set_reveal_child (IntPtr raw, bool reveal_child);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool gtk_revealer_get_child_revealed (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint gtk_revealer_get_transition_duration (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_revealer_set_transition_duration (IntPtr raw, uint duration);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int gtk_revealer_get_transition_type (IntPtr raw);

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void gtk_revealer_set_transition_type (IntPtr raw, int type);


		//
		//	Properties
		//

		[Property ("child-revealed")]
		//Whether the child is revealed and the animation target reached.
		public bool ChildRevealed {
			get{
				return Revealer.gtk_revealer_get_child_revealed (base.Handle);
			}
		}

		[Property ("reveal-child")]
		//Whether the container should reveal the child.
		public bool RevealChild {
			get {
				return Revealer.gtk_revealer_get_reveal_child (base.Handle);
			}
			set{
				Revealer.gtk_revealer_set_reveal_child (base.Handle, value);
			}
		}

		[Property ("transition-duration")]
		//The animation duration, in milliseconds.
		public uint TransitionDuration {
			get {
				return Revealer.gtk_revealer_get_transition_duration (base.Handle);
			}
			set {
				Revealer.gtk_revealer_set_transition_duration (base.Handle, value);
			}
		
		}

		[Property ("transition-type")]
		//The type of animation used to transition.
		public RevealerTransitionType TransitionType {
			get {
				return (RevealerTransitionType)Revealer.gtk_revealer_get_transition_type (base.Handle);
			}
			set {
				Revealer.gtk_revealer_set_transition_type (base.Handle, (int)value);
			}

		}

		//
		// Constructors
		//

		//protected Revealer() : base(IntPtr.Zero){}

		public Revealer(IntPtr raw) : base(IntPtr.Zero)
		{
			this.Raw = raw;
		}

		public Revealer() : base(IntPtr.Zero) 
		{
			this.Raw = Revealer.gtk_revealer_new ();
		}

	}

}
