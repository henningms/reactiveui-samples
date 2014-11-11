# iOS.TestDataBindings

This is a simple iOS application that demonstrates how to do `two-way data-binding` and `one-way data-binding`:

### One way binding
One way binding binds a property on a View to a property on a ViewModel. When the property on the ViewModel changes
```c#
// Specify what ViewModel (object to bind a property on), which property on that ViewModel and then which property in the 
// View to bind to
this.OneWayBind(ViewModel, viewModel => viewModel.Title, view => view.TitleToChangeLabel.Text)
```

```c#
TWO-WAY-BINDING
// Specify what ViewModel (object to bind a property on), which property on that ViewModel and then which property in the 
// View to bind to
this.Bind(ViewModel, viewModel => viewModel.Title, view => view.ChangeTitleTextField.Text)
```

