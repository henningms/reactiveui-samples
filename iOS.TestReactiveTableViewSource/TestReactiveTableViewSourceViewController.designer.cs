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
	[Register ("TestReactiveTableViewSourceViewController")]
	partial class TestReactiveTableViewSourceViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView TestModelTableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (TestModelTableView != null) {
				TestModelTableView.Dispose ();
				TestModelTableView = null;
			}
		}
	}
}
