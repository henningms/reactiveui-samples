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

namespace TestReactiveTableViewSource
{
	[Register ("TestPrototypeCell")]
	partial class TestPrototypeCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel TitleTextLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (TitleTextLabel != null) {
				TitleTextLabel.Dispose ();
				TitleTextLabel = null;
			}
		}
	}
}
