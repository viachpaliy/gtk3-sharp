using System;

namespace Gtk3
{
	public enum CssSectionType
	{
		GTK_CSS_SECTION_DOCUMENT,	//The section describes a complete document. 
									//This section time is the only one where gtk_css_section_get_parent() might return NULL.

		GTK_CSS_SECTION_IMPORT,		//The section defines an import rule.

		GTK_CSS_SECTION_COLOR_DEFINITION, //The section defines a color. This is a GTK extension to CSS.

		GTK_CSS_SECTION_BINDING_SET, //The section defines a binding set. This is a GTK extension to CSS.

		GTK_CSS_SECTION_RULESET, 	//The section defines a CSS ruleset.

		GTK_CSS_SECTION_SELECTOR,	//The section defines a CSS selector.

		GTK_CSS_SECTION_DECLARATION,  //The section defines the declaration of a CSS variable.

		GTK_CSS_SECTION_VALUE, 		//The section defines the value of a CSS declaration.

		GTK_CSS_SECTION_KEYFRAMES   //The section defines keyframes. See CSS Animations for details. Since 3.6
	}
}

