// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.
using System;

namespace Gtk3 {

	public partial class Global {

		internal const string GtkNativeDll = "libgtk-3.so.0";

		internal const string AtkNativeDll="libatk-1.0.so.0";

		internal const string GioNativeDll = "libgio-2.0.so.0";

		#region StyleProvider priority

		internal const uint GTK_STYLE_PROVIDER_PRIORITY_FALLBACK = 1;
		//The priority used for default style information that is used in the absence of themes.

		internal const uint GTK_STYLE_PROVIDER_PRIORITY_THEME = 200;
		//The priority used for style information provided by themes.

		internal const uint GTK_STYLE_PROVIDER_PRIORITY_SETTINGS = 400;
		//The priority used for style information provided via GtkSettings.

		internal const uint GTK_STYLE_PROVIDER_PRIORITY_APPLICATION = 600;
		//A priority that can be used when adding a GtkStyleProvider for application-specific style information.

		internal const uint GTK_STYLE_PROVIDER_PRIORITY_USER = 800;
		//The priority used for the style information from ~/.gtk-3.0.css.

		#endregion
//		public static bool ShowUri (string uri)
//		{
//			return ShowUri (null, uri);
//		}
//
//		public static bool ShowUri (Gdk.Screen screen, string uri)
//		{
//			return ShowUri (screen, uri, Gtk.Global.CurrentEventTime);
//		}
	}
}
