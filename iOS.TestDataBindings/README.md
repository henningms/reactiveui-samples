# iOS.TestDataBindings

This is a simple iOS application that demonstrates how to do `two-way data-binding` and `one-way data-binding`:

### Enabling data-binding with `ReactiveObject`

To enable data-binding on objects we need a way to notify that properties has changed. For those coming from WPF, Windows Phone, WinRT or the like are familiar with data-binding and `INotifyPropertyChanged` interface. You could implement this interface and use it like you would normally, or you could inherit from `ReactiveObject` and get a lot of neat features:

```c#
public class TestModel : ReactiveObject
{

}
```

Lets add a property and notify using the `RaiseAndSetIfChanged` method when the property's value is set:

```c#
private string _title;

public string Title
{
    get { return _title; }
    set { _title = this.RaiseAndSetIfChanged(ref _title, value); }
}
```

This will notify any listeners when the value has changed.

### One way binding
One way binding binds a property on a View to a property on a ViewModel. When the property on the ViewModel changes the property on the View will also change. If the property on the View changes this will not affect the ViewModel.

```c#
// Specify what ViewModel (object to bind a property on), which property on that ViewModel
// and then which property in the View to bind to
this.OneWayBind(ViewModel, viewModel => viewModel.Title, view => view.TitleToChangeLabel.Text)
```

### Two-way binding
Difference from the one-way binding is that the ViewModel property gets updated when the View-property updates. You can change either the ViewModel or the View and it will update both properties.

```c#
// Specify what ViewModel (object to bind a property on), which property on that ViewModel 
// and then which property in the View to bind to
this.Bind(ViewModel, viewModel => viewModel.Title, view => view.ChangeTitleTextField.Text)
```

