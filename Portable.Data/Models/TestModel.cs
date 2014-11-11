using ReactiveUI;

namespace Portable.Data.Models
{
    public class TestModel : ReactiveObject
    {
        private string _title;
        private string _subtitle;

        public string Title
        {
            get { return _title; }
            set { _title = this.RaiseAndSetIfChanged(ref _title, value); }
        }

        public string Subtitle
        {
            get { return _subtitle; }
            set { _subtitle = this.RaiseAndSetIfChanged(ref _subtitle, value); }
        }
    }
}
