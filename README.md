# gtk3-sharp is a Mono/.NET binding to Gtk+3 GUI toolkit

This is the simplest Gtk+3 program you can write:
using System;
using Atk;
using GLib;
using Gtk3;

namespace Test
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Gtk3.Application.Init();
			Gtk3.Window win = new Gtk3.Window (WindowType.Toplevel);
			win.Title = "Test gtk3-sharp";
			win.Name = "MyWindow";
			string CssData = "#MyWindow {\n    background-color: #F00;\n}";
			Gtk3.CssProvider provider = new Gtk3.CssProvider ();
			Gtk3.StyleContext.AddProviderForScreen (provider,win);
			provider.LoadFromData (CssData);
			win.ButtonPressEvent += delegate {
				provider.LoadFromData ("#MyWindow {\n    background-color: #0F0;\n}");
			};
			win.DeleteEvent += delegate {
				Gtk3.Application.Quit ();
			};
			win.ShowAll ();
			Gtk3.Application.Run ();
		}

	}
}
