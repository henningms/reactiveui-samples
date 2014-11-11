using System;
using Portable.Data.Models;
using ReactiveUI;

namespace TestReactiveTableViewSource.Cells
{
	partial class TestPrototypeCell : ReactiveTableViewCell, IViewFor<TestModel>
	{
	    private TestModel _viewModel;

	    object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (TestModel)value; }
        }

	    public TestModel ViewModel
	    {
	        get { return _viewModel; }
	        set { _viewModel = this.RaiseAndSetIfChanged(ref _viewModel, value); }
	    }

	    public TestPrototypeCell (IntPtr handle) : base (handle)
	    {
            //this.WhenAny(vm => vm.ViewModel, vm => vm.Value != null).Subscribe(b =>
            //{
            //    TitleTextLabel.Text = ViewModel.Title;
            //});

	        //
	    }

	    public override void AwakeFromNib()
	    {
	        base.AwakeFromNib();

            this.OneWayBind(ViewModel, vm => vm.Title, view => view.TitleTextLabel.Text);
	    }
	}
}
