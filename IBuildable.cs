using System;
using GLib;

namespace Gtk3
{
	public interface IBuildable
	{
		void SetName (string name);

		string GetName();

		void AddChild (Builder builder,Widget child, string type);

		void AddChild (Builder builder,Widget child);

		void SetBuildableProperty (Builder builder, string name, GLib.Value value);

		Gtk3.Widget ConstructChild (Builder builder, string name);

		void CustomTagEnd (Builder builder, Widget child, string tagname, string data);

		void CustomFinished (Builder builder, Widget child, string tagname, string data);

		void ParserFinished (Builder builder);

		Gtk3.Widget GetInternalChild (Builder builder, string childname);
	}
}

