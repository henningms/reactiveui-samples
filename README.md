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

# Troubleshooting

### Crazy Mono.Debugging exception

Gotten any of these?

![alt text](http://www.henning.ms/wp-content/uploads/2014/11/weird-mono-exception-01.png "Weird Mono Exception 01")

or

![alt text](http://www.henning.ms/wp-content/uploads/2014/11/weird-mono-exception-02.png "Weird Mono Exception 02")

If you have then be careful to check that you are referencing or setting the property on the view you are binding to:

**Causes exception**
```c#

//ChangeTitleTextField.Text isn't set
this.Bind(ViewModel, vm => vm.Title, view => view.ChangeTitleTextField.Text);
```

**All good**
```c#

ChangeTitleTextField.Text = "";
this.Bind(ViewModel, vm => vm.Title, view => view.ChangeTitleTextField.Text);
```

This is particularly for TextFields. There are no problems initiating a binding to e.g labels.
