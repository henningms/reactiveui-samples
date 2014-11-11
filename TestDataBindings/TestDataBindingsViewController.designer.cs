// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace TestDataBindings
{
	[Register ("TestDataBindingsViewController")]
	partial class TestDataBindingsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField ChangeTitleTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel TitleToChangeLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ChangeTitleTextField != null) {
				ChangeTitleTextField.Dispose ();
				ChangeTitleTextField = null;
			}
			if (TitleToChangeLabel != null) {
				TitleToChangeLabel.Dispose ();
				TitleToChangeLabel = null;
			}
		}
	}
}
