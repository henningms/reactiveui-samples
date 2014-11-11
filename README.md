reactiveui-samples
==================

Sample code from journeying through ReactiveUI

Each project is prefixed with platform or project type so it is easier to navigate the solution when you are looking for something specific:

| Name | Example |
|------|---------|
| Portable | Portable.DataLayer |
| iOS | iOS.TestDataBindings |
| Android | Android.TestDataBindings |
| WinPhone | WinPhone.TestDataBindings |

# D.R.Y

This is the D.R.Y section where we put documentation that we find ourselves repeating in projects' README files.

### IViewFor<TViewModel>

This interface you will be using a lot. In case your IDE does not have actions for auto-implementing it here's a sample.

**You will see this, but remember to cast to the appropriate class in the IViewFor.ViewModel setter**

```c#
class Something : ViewFor<TestModel>
{
	    private YourViewModel _viewModel;

	    object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (YourViewModel)value; }
        }

	    public YourViewModel ViewModel
	    {
	        get { return _viewModel; }
	        set { _viewModel = this.RaiseAndSetIfChanged(ref _viewModel, value); }
	    }
}
```
