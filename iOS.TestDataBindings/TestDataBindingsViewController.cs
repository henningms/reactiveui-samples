using System;
using System.Diagnostics;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Portable.Data.ViewModels;
using ReactiveUI;

namespace TestDataBindings
{
    public partial class TestDataBindingsViewController : UIViewController, IViewFor<TestViewModel>
    {
        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (TestViewModel)value; }
        }

        public TestViewModel ViewModel { get; set; }

        public TestDataBindingsViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            ViewModel = new TestViewModel();

            ViewModel.Title = "Sample title you can change!";
            ChangeTitleTextField.Text = "";

            this.OneWayBind(ViewModel, vm => vm.Title, view => view.TitleToChangeLabel.Text);
            this.Bind(ViewModel, vm => vm.Title, view => view.ChangeTitleTextField.Text);
        }

        
    }
}