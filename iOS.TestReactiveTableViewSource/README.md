# iOS.TestReactiveTableViewSource

This project is a simple Xamarin.iOS app that utilizes the `ReactiveTableViewSource` and `ReactiveTableViewCell` for data-binding TableViews and lists. The `Reactive`-classes will ensure to update the TableView when new items are added, updated or removed from the list.

We are using simple data-binding in our `ReactiveTableViewCell`-cells for updating UI components when the underlying model is set or changed.

Always remember IViewFor<TViewModel> interface
