using System;

namespace Gtk3
{
	public interface IOrientable
		{
		Orientation GetOrientation();
		void SetOrientation(Orientation orientation);
	}
}

