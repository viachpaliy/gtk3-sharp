using System;

namespace Gtk3
{
	public enum DialogFlags
	{
		Modal ,//GTK_DIALOG_MODAL	Make the constructed dialog modal

		DestroyWithParent ,//GTK_DIALOG_DESTROY_WITH_PARENT
		                        // Destroy the dialog when its parent is destroyed

		UseHeaderBar //GTK_DIALOG_USE_HEADER_BAR
				     //Create dialog with actions in header bar instead of action area. 
	}
}

