using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Portable.Data.Models;
using Portable.Data.ViewModels;
using ReactiveUI;
using TestReactiveTableViewSource.Cells;

namespace TestReactiveTableViewSource
{
    public partial class TestReactiveTableViewSourceViewController : UIViewController, IViewFor<TestViewModel>
    {
        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (TestViewModel)value; }
        }

        public TestViewModel ViewModel { get; set; }

        public TestReactiveTableViewSourceViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Instantiate our ViewModel and new up the list
            ViewModel = new TestViewModel();
            ViewModel.ListOfTestModels = new ReactiveList<TestModel>();

            // If we want to use a standard cell (hardcoded) we can register one for use here
            TestModelTableView.RegisterClassForCellReuse(typeof(TestStandardTableViewCell), new NSString(TestStandardTableViewCell.Key));

            // If we want to use a cell from a Xib we can use that as well
            //TestModelTableView.RegisterNibForCellReuse(UINib, CellKey);

            // Here we use a prototype cell designed in a storyboard
            var tableViewSource = new ReactiveTableViewSource<TestModel>(TestModelTableView, ViewModel.ListOfTestModels,
                new NSString("TestPrototypeCell"), 55);

            TestModelTableView.Source = tableViewSource;

            ViewModel.DoRandomDataInsertionAtTimes();
        }
    }
}