using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reactive.Linq;
using System.Text;
using MonoTouch.UIKit;
using Portable.Data.Models;
using ReactiveUI;

namespace TestReactiveTableViewSource.Cells
{
    public class TestStandardTableViewCell : ReactiveTableViewCell, IViewFor<TestModel>
    {
        public static string Key = "TestStandardTableViewCell";

        public TestStandardTableViewCell(IntPtr handle) : base(handle)
        {
            InitializeView();
        }

        private void InitializeView()
        {
            this.OneWayBind(ViewModel, vm => vm.Title, view => view.TextLabel.Text);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (TestModel)value; }
        }

        private TestModel _viewModel;

        public TestModel ViewModel
        {
            get { return _viewModel; }
            set { 
                this.RaiseAndSetIfChanged(ref _viewModel, value); }
        }


    }
}
